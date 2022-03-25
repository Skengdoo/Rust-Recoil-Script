using System;
using System.Threading;
using System.Windows.Forms;

namespace Sens_Amethyst_Recoil
{
	// Token: 0x02000004 RID: 4
	internal class Hotkeys
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000D RID: 13 RVA: 0x0000248C File Offset: 0x0000068C
		// (remove) Token: 0x0600000E RID: 14 RVA: 0x000024C0 File Offset: 0x000006C0
		private static event EventHandler<Hotkeys.HotKeyEventArgs> HotKeyPressed;

		// Token: 0x0600000F RID: 15 RVA: 0x000024F3 File Offset: 0x000006F3
		static Hotkeys()
		{
			new Thread(delegate ()
			{
				Application.Run(new Hotkeys.MessageWindow());
			})
			{
				Name = "HotKeyMessageThread",
				IsBackground = true
			}.Start();
		}

		// Token: 0x04000002 RID: 2
		private static volatile Hotkeys.MessageWindow _wnd;

		// Token: 0x04000003 RID: 3
		private static volatile IntPtr _hwnd;

		// Token: 0x04000004 RID: 4
		private static ManualResetEvent _windowReadyEvent = new ManualResetEvent(false);

		// Token: 0x02000009 RID: 9
		private class MessageWindow : Form
		{
			// Token: 0x0600001B RID: 27 RVA: 0x00002A9A File Offset: 0x00000C9A
			public MessageWindow()
			{
				Hotkeys._wnd = this;
				Hotkeys._hwnd = base.Handle;
				Hotkeys._windowReadyEvent.Set();
			}

			// Token: 0x0600001C RID: 28 RVA: 0x00002AC2 File Offset: 0x00000CC2
			protected override void WndProc(ref Message m)
			{
				if (m.Msg == 786)
				{
					Hotkeys.Hotkey.OnHotKeyPressed(new Hotkeys.HotKeyEventArgs(m.LParam));
				}
				base.WndProc(ref m);
			}

			// Token: 0x0600001D RID: 29 RVA: 0x00002AEA File Offset: 0x00000CEA
			protected override void SetVisibleCore(bool value)
			{
				base.SetVisibleCore(false);
			}

			// Token: 0x04000021 RID: 33
			private const int WM_HOTKEY = 786;
		}

		// Token: 0x0200000A RID: 10
		[Flags]
		public enum KeyModifiers
		{
			// Token: 0x04000023 RID: 35
			Control = 2
		}

		// Token: 0x0200000B RID: 11
		public class HotKeyEventArgs : EventArgs
		{
			// Token: 0x0600001E RID: 30 RVA: 0x00002AF4 File Offset: 0x00000CF4
			public HotKeyEventArgs(IntPtr hotKeyParam)
			{
				uint num = (uint)hotKeyParam.ToInt64();
				this.Key = (Keys)((num & 4294901760u) >> 16);
				this.Modifiers = (Hotkeys.KeyModifiers)(num & 65535u);
			}

			// Token: 0x04000024 RID: 36
			public readonly Keys Key;

			// Token: 0x04000025 RID: 37
			public readonly Hotkeys.KeyModifiers Modifiers;
		}

		// Token: 0x0200000C RID: 12
		public class Initiate
		{
			// Token: 0x0600001F RID: 31 RVA: 0x00002B30 File Offset: 0x00000D30
			public static int RegisterHotKey(Keys key, Hotkeys.KeyModifiers modifiers)
			{
				Hotkeys._windowReadyEvent.WaitOne();
				int num = Interlocked.Increment(ref Hotkeys.Initiate._id);
				Hotkeys._wnd.Invoke(new Hotkeys.Initiate.RegisterHotKeyDelegate(Hotkeys.Initiate.RegisterHotKeyInternal), new object[]
				{
					Hotkeys._hwnd,
					num,
					(uint)modifiers,
					(uint)key
				});
				return num;
			}

			// Token: 0x06000020 RID: 32 RVA: 0x00002B9D File Offset: 0x00000D9D
			private static void RegisterHotKeyInternal(IntPtr hwnd, int id, uint modifiers, uint key)
			{
				DLLImports.RegisterHotKey(hwnd, id, modifiers, key);
			}

			// Token: 0x06000021 RID: 33 RVA: 0x00002BAC File Offset: 0x00000DAC
			public static void InitiateHotKeys()
			{
				Hotkeys.Initiate.RegisterHotKey(Keys.Tab, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F1, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F2, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F3, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F4, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F5, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F6, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F7, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F8, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.F9, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Left, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Right, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.OemQuestion, Hotkeys.KeyModifiers.Control);
				Hotkeys.Initiate.RegisterHotKey(Keys.Return, Hotkeys.KeyModifiers.Control);
				Hotkeys.HotKeyPressed += Hotkeys.Hotkey.HotKeys_HotKeyPressed;
			}

			// Token: 0x04000026 RID: 38
			private static int _id;

			// Token: 0x02000018 RID: 24
			// (Invoke) Token: 0x06000069 RID: 105
			private delegate void RegisterHotKeyDelegate(IntPtr hwnd, int id, uint modifiers, uint key);
		}

		// Token: 0x0200000D RID: 13
		public class Hotkey
		{
			// Token: 0x06000023 RID: 35 RVA: 0x00002C4C File Offset: 0x00000E4C
			public static void OnHotKeyPressed(Hotkeys.HotKeyEventArgs e)
			{
				EventHandler<Hotkeys.HotKeyEventArgs> hotKeyPressed = Hotkeys.HotKeyPressed;
				if (hotKeyPressed != null)
				{
					hotKeyPressed(null, e);
				}
			}

			// Token: 0x06000024 RID: 36 RVA: 0x00002C6C File Offset: 0x00000E6C
			public static void HotKeys_HotKeyPressed(object sender, Hotkeys.HotKeyEventArgs e)
			{
				Keys key = e.Key;
				if (key <= Keys.Return)
				{
					if (key != Keys.Tab)
					{
						if (key == Keys.Return)
						{
							Variables.Weapon.barrelIndex++;
							Variables.Weapon.changeBarrel();
						}
					}
					else
					{
						Variables.Menu.setEnabled(!Variables.Menu.isEnabled());
					}
				}
				else if (key != Keys.Left)
				{
					if (key == Keys.Right)
					{
						Variables.Settings.setSensitivity(1);
					}
					else
					{
						switch (key)
						{
							case Keys.F1:
								Weapons.setVariables(1);
								break;
							case Keys.F2:
								Weapons.setVariables(2);
								break;
							case Keys.F3:
								Weapons.setVariables(3);
								break;
							case Keys.F4:
								Weapons.setVariables(4);
								break;
							case Keys.F5:
								Weapons.setVariables(5);
								break;
							case Keys.F6:
								Weapons.setVariables(6);
								break;
							case Keys.F7:
								Weapons.setVariables(7);
								break;
							case Keys.F8:
								Weapons.setVariables(8);
								break;
							case Keys.F9:
								Weapons.setVariables(9);
								break;
							default:
								if (key == Keys.OemQuestion)
								{
									Variables.Weapon.scopeIndex++;
									Variables.Weapon.changeScope();
								}
								break;
						}
					}
				}
				else
				{
					Variables.Settings.setSensitivity(-1);
				}
				Console.Clear();
			}
		}
	}
}
