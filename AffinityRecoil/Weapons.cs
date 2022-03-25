using System;

namespace Sens_Amethyst_Recoil
{
	// Token: 0x02000007 RID: 7
	internal class Weapons
	{
		// Token: 0x06000018 RID: 24 RVA: 0x000026F8 File Offset: 0x000008F8
		public static void setVariables(int weaponIndex)
		{
			switch (weaponIndex)
			{
				case 1:
					Variables.Weapon.setName("Assault Rifle");
					Variables.Weapon.setRecoilPattern(Weapons.AssaultRifle);
					Variables.Weapon.setShotDelay(Weapons.AssaultRifleControlTime);
					Variables.Weapon.setShootingMilliSec(133);
					Variables.Weapon.setAmmo(29);
					return;
				case 2:
					Variables.Weapon.setName("LR-300 Assault Rifle");
					Variables.Weapon.setRecoilPattern(Weapons.LR300AssaultRifle);
					Variables.Weapon.setShotDelay(Weapons.LRControlTime);
					Variables.Weapon.setShootingMilliSec(120);
					Variables.Weapon.setAmmo(29);
					return;
				case 3:
					Variables.Weapon.setName("Semi Assult Rifle");
					Variables.Weapon.setRecoilPattern(Weapons.SemiAssultRifle);
					Variables.Weapon.setShotDelay(Weapons.SemiControlTime);
					Variables.Weapon.setShootingMilliSec(175);
					Variables.Weapon.setAmmo(1);
					return;
				case 4:
					Variables.Weapon.setName("Custom SMG");
					Variables.Weapon.setRecoilPattern(Weapons.CustomSMG);
					Variables.Weapon.setShotDelay(Weapons.CustomSMGControlTime);
					Variables.Weapon.setShootingMilliSec(100);
					Variables.Weapon.setAmmo(23);
					return;
				case 5:
					Variables.Weapon.setName("MP5A4");
					Variables.Weapon.setRecoilPattern(Weapons.MP5A4);
					Variables.Weapon.setShotDelay(Weapons.MP5A4ControlTime);
					Variables.Weapon.setShootingMilliSec(100);
					Variables.Weapon.setAmmo(29);
					return;
				case 6:
					Variables.Weapon.setName("Thompson");
					Variables.Weapon.setRecoilPattern(Weapons.Thompson);
					Variables.Weapon.setShotDelay(Weapons.ThompsonControlTime);
					Variables.Weapon.setShootingMilliSec(130);
					Variables.Weapon.setAmmo(19);
					return;
				case 7:
					Variables.Weapon.setName("M92");
					Variables.Weapon.setRecoilPattern(Weapons.M92);
					Variables.Weapon.setShotDelay(Weapons.M92Time);
					Variables.Weapon.setShootingMilliSec(100);
					Variables.Weapon.setAmmo(1);
					return;
				case 8:
					Variables.Weapon.setName("M39");
					Variables.Weapon.setRecoilPattern(Weapons.M39);
					Variables.Weapon.setShotDelay(Weapons.M39ControlTime);
					Variables.Weapon.setShootingMilliSec(150);
					Variables.Weapon.setAmmo(1);
					return;
				case 9:
					Variables.Weapon.setName("M249");
					Variables.Weapon.setRecoilPattern(Weapons.M249);
					Variables.Weapon.setShotDelay(Weapons.M249ControlTime);
					Variables.Weapon.setShootingMilliSec(120);
					Variables.Weapon.setAmmo(1);
					return;
				default:
					return;
			}
		}
		static Weapons()
		{
			int[,] array = new int[2, 2];
			array[0, 1] = 75;
			array[1, 1] = 75;
			Weapons.SemiAssultRifle = array;
			Weapons.SemiControlTime = new double[]
			{
				175.0
			};
			Weapons.CustomSMG = new int[,]
			{
				{
					-28,
					52
				},
				{
					-10,
					53
				},
				{
					0,
					53
				},
				{
					11,
					44
				},
				{
					20,
					45
				},
				{
					22,
					42
				},
				{
					17,
					35
				},
				{
					7,
					30
				},
				{
					-9,
					27
				},
				{
					-13,
					28
				},
				{
					-23,
					22
				},
				{
					-21,
					21
				},
				{
					-15,
					24
				},
				{
					0,
					13
				},
				{
					20,
					14
				},
				{
					16,
					12
				},
				{
					29,
					19
				},
				{
					7,
					6
				},
				{
					11,
					10
				},
				{
					-4,
					8
				},
				{
					-8,
					13
				},
				{
					-7,
					2
				},
				{
					-13,
					14
				},
				{
					0,
					0
				}
			};
			Weapons.CustomSMGControlTime = new double[]
			{
				72.942129,
				66.636213,
				62.974812,
				61.750535,
				60.935042,
				57.200952,
				49.164097,
				38.976078,
				35.006739,
				37.638419,
				39.18792,
				36.075356,
				28.171659,
				21.234233,
				24.358432,
				28.987042,
				29.927871,
				26.070199,
				18.11936,
				13.438176,
				16.856357,
				19.274035,
				18.320346
			};
			Weapons.MP5A4 = new int[,]
			{
				{
					0,
					43
				},
				{
					0,
					58
				},
				{
					0,
					65
				},
				{
					25,
					66
				},
				{
					59,
					58
				},
				{
					63,
					42
				},
				{
					46,
					27
				},
				{
					3,
					23
				},
				{
					-37,
					19
				},
				{
					-47,
					18
				},
				{
					-40,
					18
				},
				{
					-8,
					7
				},
				{
					16,
					12
				},
				{
					28,
					11
				},
				{
					35,
					9
				},
				{
					34,
					8
				},
				{
					25,
					6
				},
				{
					12,
					0
				},
				{
					-4,
					2
				},
				{
					-6,
					2
				},
				{
					-18,
					0
				},
				{
					-27,
					5
				},
				{
					-26,
					0
				},
				{
					-27,
					0
				},
				{
					-20,
					0
				},
				{
					-32,
					0
				},
				{
					-12,
					0
				},
				{
					-25,
					0
				},
				{
					-4,
					0
				},
				{
					0,
					0
				},
				{
					43,
					0
				},
				{
					0,
					0
				}
			};
			Weapons.MP5A4ControlTime = new double[]
			{
				43.441909,
				58.669031,
				66.411108,
				71.385438,
				83.641583,
				79.398875,
				52.763157,
				21.615756,
				40.987258,
				52.64941,
				42.242421,
				15.073904,
				19.158961,
				29.407978,
				34.560589,
				33.587834,
				26.295315,
				12.769285,
				4.207833,
				10.980831,
				17.070518,
				21.74413,
				24.917849,
				26.570261,
				26.693439,
				25.283775,
				22.339392,
				17.859221,
				11.842602
			};
			Weapons.Thompson = new int[,]
			{
				{
					-29,
					63
				},
				{
					-12,
					61
				},
				{
					9,
					61
				},
				{
					21,
					55
				},
				{
					25,
					52
				},
				{
					21,
					43
				},
				{
					5,
					32
				},
				{
					-16,
					33
				},
				{
					-24,
					25
				},
				{
					-24,
					26
				},
				{
					-14,
					21
				},
				{
					7,
					17
				},
				{
					16,
					18
				},
				{
					23,
					16
				},
				{
					25,
					17
				},
				{
					8,
					16
				},
				{
					-5,
					5
				},
				{
					-13,
					15
				},
				{
					-14,
					8
				}
			};
			Weapons.ThompsonControlTime = new double[]
			{
				86.598887,
				78.34714,
				74.40831,
				73.568908,
				69.21168,
				57.652541,
				44.231602,
				43.172386,
				46.84787,
				43.832255,
				32.594771,
				25.597451,
				32.269315,
				36.054248,
				31.898137,
				20.621504,
				16.997289,
				22.046002,
				22.69007
			};
			int[,] array2 = new int[2, 2];
			array2[0, 1] = 68;
			array2[1, 1] = 68;
			Weapons.M92 = array2;
			Weapons.M92Time = new double[]
			{
				100.0
			};
			int[,] array3 = new int[2, 2];
			array3[0, 1] = 68;
			array3[1, 1] = 68;
			Weapons.M39 = array3;
			Weapons.M39ControlTime = new double[]
			{
				151.0
			};
			int[,] array4 = new int[1, 2];
			array4[0, 1] = 115;
			Weapons.M249 = array4;
			Weapons.M249ControlTime = new double[]
			{
				151.25
			};
		}

		// Token: 0x04000005 RID: 5
		private static readonly int[,] AssaultRifle = new int[,]
		{
			{
				-69,
				100
			},
			{
				10,
				92
			},
			{
				-110,
				83
			},
			{
				-85,
				75
			},
			{
				0,
				67
			},
			{
				33,
				57
			},
			{
				58,
				48
			},
			{
				76,
				39
			},
			{
				84,
				29
			},
			{
				85,
				19
			},
			{
				76,
				20
			},
			{
				60,
				37
			},
			{
				34,
				50
			},
			{
				2,
				59
			},
			{
				-30,
				65
			},
			{
				-55,
				67
			},
			{
				-74,
				64
			},
			{
				-86,
				59
			},
			{
				-92,
				49
			},
			{
				-91,
				34
			},
			{
				-84,
				17
			},
			{
				-70,
				10
			},
			{
				-49,
				28
			},
			{
				-22,
				42
			},
			{
				24,
				51
			},
			{
				72,
				56
			},
			{
				97,
				57
			},
			{
				98,
				51
			},
			{
				77,
				43
			}
		};

		// Token: 0x04000006 RID: 6
		private static readonly double[] AssaultRifleControlTime = new double[]
		{
			121.96149709966872,
			92.6333814724611,
			138.60598637206294,
			113.37874368443146,
			66.251511864277447,
			66.295304380193542,
			75.9327831420658,
			85.055261442561573,
			89.20256669256554,
			86.680101846679875,
			78.821458883177883,
			70.0451048111144,
			60.859796045829782,
			59.516424576246187,
			71.667629962836074,
			86.740600094030341,
			98.3363599080854,
			104.34161954944257,
			104.09299204005345,
			97.587807469017392,
			85.48062700875559,
			70.4889202349561,
			56.564178115305452,
			47.386907899993936,
			56.637874086802469,
			91.5937793023631,
			112.38667610336424,
			111.39338971888095,
			87.5067801164596
		};

		// Token: 0x04000007 RID: 7
		private static readonly int[,] LR300AssaultRifle = new int[,]
		{
			{
				0,
				50
			},
			{
				-11,
				60
			},
			{
				-22,
				67
			},
			{
				-28,
				59
			},
			{
				-31,
				50
			},
			{
				-29,
				42
			},
			{
				-9,
				38
			},
			{
				-9,
				30
			},
			{
				23,
				25
			},
			{
				36,
				24
			},
			{
				35,
				13
			},
			{
				40,
				19
			},
			{
				18,
				6
			},
			{
				0,
				17
			},
			{
				-13,
				6
			},
			{
				-16,
				5
			},
			{
				-19,
				6
			},
			{
				-34,
				12
			},
			{
				-31,
				2
			},
			{
				-29,
				5
			},
			{
				-28,
				0
			},
			{
				-21,
				5
			},
			{
				-12,
				13
			},
			{
				-7,
				0
			},
			{
				19,
				5
			},
			{
				3,
				11
			},
			{
				61,
				0
			},
			{
				73,
				0
			},
			{
				54,
				6
			},
			{
				0,
				8
			},
			{
				50,
				0
			}
		};

		// Token: 0x04000008 RID: 8
		private static readonly double[] LRControlTime = new double[]
		{
			50.486527,
			63.409837,
			69.352231,
			69.019084,
			60.342866,
			50.279209,
			40.623896,
			30.626204,
			31.369554,
			40.533283,
			43.897277,
			38.230196,
			23.219868,
			9.947927,
			14.267603,
			20.268351,
			25.38681,
			29.051251,
			31.098685,
			31.469423,
			30.140472,
			27.108869,
			22.395387,
			16.088652,
			8.546886,
			27.487437,
			61.53372,
			72.697228,
			60.831257
		};

		// Token: 0x04000009 RID: 9
		private static readonly int[,] SemiAssultRifle;

		// Token: 0x0400000A RID: 10
		private static readonly double[] SemiControlTime;

		// Token: 0x0400000B RID: 11
		private static readonly int[,] CustomSMG;

		// Token: 0x0400000C RID: 12
		private static readonly double[] CustomSMGControlTime;

		// Token: 0x0400000D RID: 13
		private static readonly int[,] MP5A4;

		// Token: 0x0400000E RID: 14
		private static readonly double[] MP5A4ControlTime;

		// Token: 0x0400000F RID: 15
		private static readonly int[,] Thompson;

		// Token: 0x04000010 RID: 16
		private static readonly double[] ThompsonControlTime;

		// Token: 0x04000011 RID: 17
		private static readonly int[,] M92;

		// Token: 0x04000012 RID: 18
		private static readonly double[] M92Time;

		// Token: 0x04000013 RID: 19
		private static readonly int[,] M39;

		// Token: 0x04000014 RID: 20
		private static readonly double[] M39ControlTime;

		// Token: 0x04000015 RID: 21
		private static readonly int[,] M249;

		// Token: 0x04000016 RID: 22
		private static readonly double[] M249ControlTime;
	}
}
