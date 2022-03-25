using System;

namespace Sens_Amethyst_Recoil
{
	// Token: 0x02000006 RID: 6
	internal class Variables
	{
		// Token: 0x0200000F RID: 15
		public class Menu
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000029 RID: 41 RVA: 0x00002D8D File Offset: 0x00000F8D
			// (set) Token: 0x0600002A RID: 42 RVA: 0x00002D94 File Offset: 0x00000F94
			private static bool Enabled { get; set; }

			// Token: 0x0600002B RID: 43 RVA: 0x00002D9C File Offset: 0x00000F9C
			public static bool isEnabled()
			{
				return Variables.Menu.Enabled;
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00002DA3 File Offset: 0x00000FA3
			public static void setEnabled(bool boolean)
			{
				Variables.Menu.Enabled = boolean;
			}
		}

		// Token: 0x02000010 RID: 16
		public class Weapon
		{
			// Token: 0x17000002 RID: 2
			// (get) Token: 0x0600002E RID: 46 RVA: 0x00002DAB File Offset: 0x00000FAB
			// (set) Token: 0x0600002F RID: 47 RVA: 0x00002DB2 File Offset: 0x00000FB2
			private static string Name { get; set; } = string.Empty;

			// Token: 0x06000030 RID: 48 RVA: 0x00002DBC File Offset: 0x00000FBC
			public static string getName()
			{
				string result;
				if (!string.IsNullOrEmpty(Variables.Weapon.Name))
				{
					result = Variables.Weapon.Name;
				}
				else
				{
					result = "None";
				}
				return result;
			}

			// Token: 0x06000031 RID: 49 RVA: 0x00002DE7 File Offset: 0x00000FE7
			public static void setName(string newName)
			{
				Variables.Weapon.Name = newName;
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000032 RID: 50 RVA: 0x00002DEF File Offset: 0x00000FEF
			// (set) Token: 0x06000033 RID: 51 RVA: 0x00002DF6 File Offset: 0x00000FF6
			private static int Ammo { get; set; } = 0;

			// Token: 0x06000034 RID: 52 RVA: 0x00002DFE File Offset: 0x00000FFE
			public static int getAmmo()
			{
				return Variables.Weapon.Ammo;
			}

			// Token: 0x06000035 RID: 53 RVA: 0x00002E05 File Offset: 0x00001005
			public static void setAmmo(int AmmoSize)
			{
				Variables.Weapon.Ammo = AmmoSize;
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000036 RID: 54 RVA: 0x00002E0D File Offset: 0x0000100D
			// (set) Token: 0x06000037 RID: 55 RVA: 0x00002E14 File Offset: 0x00001014
			private static int[,] ActiveRecoil { get; set; } = new int[1, 2];

			// Token: 0x06000038 RID: 56 RVA: 0x00002E1C File Offset: 0x0000101C
			public static int getRecoilX(int Bullet)
			{
				return Variables.Weapon.ActiveRecoil[Bullet, 0];
			}

			// Token: 0x06000039 RID: 57 RVA: 0x00002E2A File Offset: 0x0000102A
			public static int getRecoilY(int Bullet)
			{
				return Variables.Weapon.ActiveRecoil[Bullet, 1];
			}

			// Token: 0x0600003A RID: 58 RVA: 0x00002E38 File Offset: 0x00001038
			public static void setRecoilPattern(int[,] Pattern)
			{
				Variables.Weapon.ActiveRecoil = Pattern;
			}

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600003B RID: 59 RVA: 0x00002E40 File Offset: 0x00001040
			// (set) Token: 0x0600003C RID: 60 RVA: 0x00002E47 File Offset: 0x00001047
			private static double[] Delay { get; set; } = new double[1];

			// Token: 0x0600003D RID: 61 RVA: 0x00002E4F File Offset: 0x0000104F
			public static double getShotDelay(int Bullet)
			{
				return Variables.Weapon.Delay[Bullet];
			}

			// Token: 0x0600003E RID: 62 RVA: 0x00002E58 File Offset: 0x00001058
			public static void setShotDelay(double[] Delays)
			{
				Variables.Weapon.Delay = Delays;
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600003F RID: 63 RVA: 0x00002E60 File Offset: 0x00001060
			// (set) Token: 0x06000040 RID: 64 RVA: 0x00002E67 File Offset: 0x00001067
			private static int ShootingMilliSec { get; set; } = 0;

			// Token: 0x06000041 RID: 65 RVA: 0x00002E6F File Offset: 0x0000106F
			public static int getShootingMilliSec()
			{
				return Variables.Weapon.ShootingMilliSec;
			}

			// Token: 0x06000042 RID: 66 RVA: 0x00002E76 File Offset: 0x00001076
			public static void setShootingMilliSec(int MilliSec)
			{
				Variables.Weapon.ShootingMilliSec = MilliSec;
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000043 RID: 67 RVA: 0x00002E7E File Offset: 0x0000107E
			// (set) Token: 0x06000044 RID: 68 RVA: 0x00002E85 File Offset: 0x00001085
			public static int scopeIndex { get; set; } = 0;

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000045 RID: 69 RVA: 0x00002E8D File Offset: 0x0000108D
			// (set) Token: 0x06000046 RID: 70 RVA: 0x00002E94 File Offset: 0x00001094
			private static string Scope { get; set; } = "None";

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000047 RID: 71 RVA: 0x00002E9C File Offset: 0x0000109C
			// (set) Token: 0x06000048 RID: 72 RVA: 0x00002EA3 File Offset: 0x000010A3
			private static double ScopeMulitplier { get; set; } = 1.0;

			// Token: 0x06000049 RID: 73 RVA: 0x00002EAC File Offset: 0x000010AC
			public static string getActiveScope()
			{
				string result;
				if (!string.IsNullOrEmpty(Variables.Weapon.Scope) && Variables.Weapon.Scope != "None")
				{
					result = Variables.Weapon.Scope;
				}
				else
				{
					result = "None";
				}
				return result;
			}

			// Token: 0x0600004A RID: 74 RVA: 0x00002EE8 File Offset: 0x000010E8
			public static void changeScope()
			{
				switch (Variables.Weapon.scopeIndex)
				{
					case 0:
						Variables.Weapon.Scope = "None";
						Variables.Weapon.ScopeMulitplier = 1.0;
						return;
					case 1:
						Variables.Weapon.Scope = "Simple scope";
						Variables.Weapon.ScopeMulitplier = 0.8;
						return;
					case 2:
						Variables.Weapon.Scope = "Holo scope";
						Variables.Weapon.ScopeMulitplier = 1.2;
						return;
					case 3:
						Variables.Weapon.Scope = "8x scope";
						Variables.Weapon.ScopeMulitplier = 3.83721;
						return;
					case 4:
						Variables.Weapon.Scope = "16x scope";
						Variables.Weapon.ScopeMulitplier = 7.65116;
						Variables.Weapon.scopeIndex = -1;
						return;
					default:
						return;
				}
			}

			// Token: 0x0600004B RID: 75 RVA: 0x00002F98 File Offset: 0x00001198
			public static double getScopeMulitplier()
			{
				return Variables.Weapon.ScopeMulitplier;
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x0600004C RID: 76 RVA: 0x00002F9F File Offset: 0x0000119F
			// (set) Token: 0x0600004D RID: 77 RVA: 0x00002FA6 File Offset: 0x000011A6
			public static int barrelIndex { get; set; } = 0;

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600004E RID: 78 RVA: 0x00002FAE File Offset: 0x000011AE
			// (set) Token: 0x0600004F RID: 79 RVA: 0x00002FB5 File Offset: 0x000011B5
			private static string Barrel { get; set; } = "None";

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000050 RID: 80 RVA: 0x00002FBD File Offset: 0x000011BD
			// (set) Token: 0x06000051 RID: 81 RVA: 0x00002FC4 File Offset: 0x000011C4
			private static double BarrelMultiplier { get; set; } = 1.0;

			// Token: 0x06000052 RID: 82 RVA: 0x00002FCC File Offset: 0x000011CC
			public static string getActiveBarrel()
			{
				string result;
				if (!string.IsNullOrEmpty(Variables.Weapon.Barrel) && Variables.Weapon.Barrel != "None")
				{
					result = Variables.Weapon.Barrel;
				}
				else
				{
					result = "None";
				}
				return result;
			}

			// Token: 0x06000053 RID: 83 RVA: 0x00003008 File Offset: 0x00001208
			public static void changeBarrel()
			{
				switch (Variables.Weapon.barrelIndex)
				{
					case 0:
						Variables.Weapon.Barrel = "None";
						Variables.Weapon.BarrelMultiplier = 1.0;
						return;
					case 1:
						Variables.Weapon.Barrel = "Suppressor";
						Variables.Weapon.BarrelMultiplier = 0.8;
						return;
					case 2:
						Variables.Weapon.Barrel = "Muzzle boost";
						Variables.Weapon.BarrelMultiplier = 1.0;
						Variables.Weapon.MuzzleBoost = true;
						return;
					case 3:
						Variables.Weapon.Barrel = "Muzzle break";
						Variables.Weapon.BarrelMultiplier = 0.5;
						Variables.Weapon.barrelIndex = -1;
						Variables.Weapon.MuzzleBoost = false;
						return;
					default:
						return;
				}
			}

			// Token: 0x06000054 RID: 84 RVA: 0x000030A7 File Offset: 0x000012A7
			public static double getBarrelMultiplier()
			{
				return Variables.Weapon.BarrelMultiplier;
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000055 RID: 85 RVA: 0x000030AE File Offset: 0x000012AE
			// (set) Token: 0x06000056 RID: 86 RVA: 0x000030B5 File Offset: 0x000012B5
			private static bool MuzzleBoost { get; set; } = false;

			// Token: 0x06000057 RID: 87 RVA: 0x000030C0 File Offset: 0x000012C0
			public static double isMuzzleBoost(double MilliSec)
			{
				double result;
				if (Variables.Weapon.MuzzleBoost)
				{
					result = MilliSec - MilliSec * 0.10000000149011612;
				}
				else
				{
					result = MilliSec;
				}
				return result;
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000058 RID: 88 RVA: 0x000030E7 File Offset: 0x000012E7
			// (set) Token: 0x06000059 RID: 89 RVA: 0x000030EE File Offset: 0x000012EE
			private static double Randomness { get; set; } = 0.0;

			// Token: 0x0600005A RID: 90 RVA: 0x000030F8 File Offset: 0x000012F8
			public static void setRandomness(int RandomnessIndex)
			{
				if (RandomnessIndex != -1)
				{
					if (RandomnessIndex == 1 && Variables.Weapon.Randomness < 10.0)
					{
						Variables.Weapon.Randomness += 1.0;
						return;
					}
				}
				else if (0.0 < Variables.Weapon.Randomness)
				{
					Variables.Weapon.Randomness -= 1.0;
				}
			}

			// Token: 0x0600005B RID: 91 RVA: 0x0000315A File Offset: 0x0000135A
			public static double getRandomness()
			{
				return Variables.Weapon.Randomness;
			}
		}

		// Token: 0x02000011 RID: 17
		public class Settings
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600005E RID: 94 RVA: 0x000031EE File Offset: 0x000013EE
			// (set) Token: 0x0600005F RID: 95 RVA: 0x000031F5 File Offset: 0x000013F5
			private static double Sensitivity { get; set; } = 1.0;

			// Token: 0x06000060 RID: 96 RVA: 0x00003200 File Offset: 0x00001400
			public static void setSensitivity(int SensitivityIndex)
			{
				if (SensitivityIndex != -1)
				{
					if (SensitivityIndex == 1 && Variables.Settings.Sensitivity < 2.0)
					{
						Variables.Settings.Sensitivity += 0.1;
						return;
					}
				}
				else if (0.2 < Variables.Settings.Sensitivity)
				{
					Variables.Settings.Sensitivity -= 0.1;
				}
			}

			// Token: 0x06000061 RID: 97 RVA: 0x00003262 File Offset: 0x00001462
			public static double getSensitivity()
			{
				return Variables.Settings.Sensitivity;
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000062 RID: 98 RVA: 0x00003269 File Offset: 0x00001469
			// (set) Token: 0x06000063 RID: 99 RVA: 0x00003270 File Offset: 0x00001470
			private static int FOV { get; set; } = 90;

			// Token: 0x06000064 RID: 100 RVA: 0x00003278 File Offset: 0x00001478
			public static void setFOV(int FOVIndex)
			{
				if (FOVIndex != -1)
				{
					if (FOVIndex == 1 && Variables.Settings.FOV < 90)
					{
						Variables.Settings.FOV++;
						return;
					}
				}
				else if (71 < Variables.Settings.FOV)
				{
					Variables.Settings.FOV--;
				}
			}

			// Token: 0x06000065 RID: 101 RVA: 0x000032B1 File Offset: 0x000014B1
			public static int getFOV()
			{
				return Variables.Settings.FOV;
			}
		}
	}
}
