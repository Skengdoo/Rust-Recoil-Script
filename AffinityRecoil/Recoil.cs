using System;
using System.Windows.Forms;

namespace Sens_Amethyst_Recoil
{
	// Token: 0x02000005 RID: 5
	internal class Recoil
	{
		// Token: 0x06000011 RID: 17 RVA: 0x0000252C File Offset: 0x0000072C
		private static bool IsKeyDown(Keys key)
		{
			return ((int)DLLImports.GetAsyncKeyState((int)key) & 32768) != 0;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002540 File Offset: 0x00000740
		public static void RecoilLoop()
		{
			for (; ; )
			{
				if (Variables.Menu.isEnabled() && !string.IsNullOrEmpty(Variables.Weapon.getName()))
				{
					while (Recoil.IsKeyDown(Keys.LButton))
					{
						if (!Recoil.IsKeyDown(Keys.RButton))
						{
							break;
						}
						int num = 0;
						while (num <= Variables.Weapon.getAmmo() - 1 && Recoil.IsKeyDown(Keys.LButton))
						{
							Recoil.Smoothing(Variables.Weapon.isMuzzleBoost((double)Variables.Weapon.getShootingMilliSec()), Variables.Weapon.isMuzzleBoost(Variables.Weapon.getShotDelay(num)), (int)(((double)Variables.Weapon.getRecoilX(num) + Recoil.GetRandomNumber(0.0, Variables.Weapon.getRandomness())) / 4.0 / Variables.Settings.getSensitivity() * Variables.Weapon.getScopeMulitplier() * Variables.Weapon.getBarrelMultiplier()), (int)(((double)Variables.Weapon.getRecoilY(num) + Recoil.GetRandomNumber(0.0, Variables.Weapon.getRandomness())) / 4.0 / Variables.Settings.getSensitivity() * Variables.Weapon.getScopeMulitplier() * Variables.Weapon.getBarrelMultiplier()));
							DLLImports.mouse_event(1, 0, 0, 0, 0);
							num++;
						}
					}
				}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002640 File Offset: 0x00000840
		private static double GetRandomNumber(double minimum, double maximum)
		{
			return new Random().NextDouble() * (maximum - minimum) + minimum;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002654 File Offset: 0x00000854
		private static void Smoothing(double MS, double ControlledTime, int X, int Y)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int i = 1; i <= (int)ControlledTime; i++)
			{
				int num4 = i * X / (int)ControlledTime;
				int num5 = i * Y / (int)ControlledTime;
				int num6 = i * (int)ControlledTime / (int)ControlledTime;
				DLLImports.mouse_event(1, num4 - num, num5 - num2, 0, 0);
				Recoil.PerciseSleep(num6 - num3);
				num = num4;
				num2 = num5;
				num3 = num6;
			}
			Recoil.PerciseSleep((int)MS - (int)ControlledTime);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000026B4 File Offset: 0x000008B4
		private static void PerciseSleep(int ms)
		{
			long num;
			DLLImports.QueryPerformanceFrequency(out num);
			num /= 1000L;
			long num2;
			DLLImports.QueryPerformanceCounter(out num2);
			long num3 = num2 / num + (long)ms;
			for (num2 = 0L; num2 < num3; num2 /= num)
			{
				DLLImports.QueryPerformanceCounter(out num2);
			}
		}
	}
}
