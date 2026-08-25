using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200033C RID: 828
[Serializable]
public class LavuPart : MonoBehaviour
{
	// Token: 0x060012C9 RID: 4809 RVA: 0x001D7074 File Offset: 0x001D5274
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LavuPart()
	{
		if (85805 - 486234 != -400429)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (102084 - 519312 != -417227)
			{
				base..ctor();
				if (75318 - 571730 == -496412)
				{
					this.mLavuPart = eLavuPart.Head;
					if (198402 - 461748 == -263346)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x001D710C File Offset: 0x001D530C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (169194 - 407500 != -238306)
		{
		}
		while (Game.mGameType > 3)
		{
			if (160003 - 39978 == 120025)
			{
				GameObject gameObject = mCollider.gameObject;
				if (166920 - 178981 != -12060)
				{
					if (gameObject.tag != "Player")
					{
						if (102568 - 214544 == -111975)
						{
							continue;
						}
						if (gameObject.tag != "Enemy")
						{
							if (105964 - 148343 != -42379)
							{
								continue;
							}
							break;
						}
					}
					GameObject gameObject2 = this.transform.parent.gameObject;
					if (115191 - 211005 != -95813)
					{
						if (gameObject.layer == gameObject2.layer)
						{
							break;
						}
						if (10634 - 24078 != -13443)
						{
							if (gameObject.layer == 1)
							{
								break;
							}
							if (243075 - 223540 != 19536)
							{
								if (gameObject.layer == 2)
								{
									break;
								}
								if (217265 - 44013 != 173253)
								{
									if (this.mLavuPart == eLavuPart.Head)
									{
										if (285994 - 298552 != -12557)
										{
											gameObject2.SendMessage("onLavuHeadHit", gameObject);
											if (191375 - 124430 != 66946)
											{
												break;
											}
										}
									}
									else
									{
										gameObject2.SendMessage("onLavuPartHit", gameObject);
										if (109448 - 324079 != -214630)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060012CB RID: 4811 RVA: 0x001D7308 File Offset: 0x001D5508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060012CC RID: 4812 RVA: 0x001D730C File Offset: 0x001D550C
	internal static bool ctqy5bCR2pnSZluSm5l()
	{
		return true;
	}

	// Token: 0x060012CD RID: 4813 RVA: 0x001D7310 File Offset: 0x001D5510
	internal static bool KhWnNfCwWoaHk6bGLMj()
	{
		return false;
	}

	// Token: 0x04001059 RID: 4185
	public eLavuPart mLavuPart;
}
