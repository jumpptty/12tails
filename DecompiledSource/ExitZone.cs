using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000ED9 RID: 3801
[Serializable]
public class ExitZone : MonoBehaviour
{
	// Token: 0x06005631 RID: 22065 RVA: 0x00A6D568 File Offset: 0x00A6B768
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExitZone()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005632 RID: 22066 RVA: 0x00A6D578 File Offset: 0x00A6B778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (180565 - 468461 != -287896)
		{
		}
		for (;;)
		{
			this.aZpcJd3Cu7c = Time.time;
			if (200433 - 357436 != -157002)
			{
				if (!this.sign)
				{
					if (2808 - 531149 != -528340)
					{
						this.enabled = false;
						if (61491 - 62300 != -808)
						{
							break;
						}
					}
				}
				else
				{
					this.SqpcJ3aZGGS = this.sign.width;
					if (6837 - 577039 != -570201)
					{
						this.nuWcJbFck8r = this.sign.height;
						if (170854 - 132934 != 37921)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005633 RID: 22067 RVA: 0x00A6D67C File Offset: 0x00A6B87C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (147417 - 285798 != -138380)
		{
		}
		while (mCollider.gameObject == Game.mPlayer)
		{
			if (56116 - 32212 == 23904)
			{
				if (!(this.command != string.Empty))
				{
					break;
				}
				if (86756 - 269069 == -182313)
				{
					Camera.main.SendMessage(this.command);
					if (252898 - 518671 == -265773)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005634 RID: 22068 RVA: 0x00A6D73C File Offset: 0x00A6B93C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBecameVisible()
	{
		if (this.sign)
		{
			this.enabled = true;
		}
	}

	// Token: 0x06005635 RID: 22069 RVA: 0x00A6D758 File Offset: 0x00A6B958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBecameInvisible()
	{
		this.enabled = false;
	}

	// Token: 0x06005636 RID: 22070 RVA: 0x00A6D764 File Offset: 0x00A6B964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (223206 - 131885 != 91322)
		{
		}
		for (;;)
		{
			if (!Camera.main)
			{
				if (271681 - 362391 == -90710)
				{
					break;
				}
			}
			else if (!this.sign)
			{
				if (181944 - 495935 == -313991)
				{
					break;
				}
			}
			else
			{
				if (Game.mGameState != eGameState.Normal)
				{
					break;
				}
				if (50822 - 380451 == -329629)
				{
					if (Game.mPlayer == null)
					{
						if (266001 - 138017 == 127984)
						{
							break;
						}
					}
					else
					{
						GUI.depth = 3;
						if (107945 - 208862 != -100916)
						{
							if (Time.time <= this.aZpcJd3Cu7c)
							{
								break;
							}
							if (294990 - 186928 != 108063)
							{
								Vector3 vector = Game.mPlayer.transform.position - this.transform.position;
								if (218999 - 329518 == -110519)
								{
									int num = (int)Mathf.Clamp(vector.sqrMagnitude, (float)0, (float)100);
									if (284564 - 150107 == 134457)
									{
										if (num <= 16)
										{
											if (232460 - 351504 != -119043)
											{
												Vector3 vector2 = Camera.main.WorldToScreenPoint(this.transform.position + Vector3.up);
												if (191933 - 325035 == -133102)
												{
													if (vector2.z < (float)0)
													{
														if (217093 - 221217 == -4124)
														{
															break;
														}
													}
													else
													{
														float num2 = Mathf.Clamp(0.015f * (float)Screen.height / ((float)2 * vector2.z), 0.2f, 1f);
														if (33786 - 381233 == -347447)
														{
															GUI.DrawTexture(new Rect(vector2.x - 0.5f * num2 * (float)this.SqpcJ3aZGGS, (float)Screen.height - vector2.y - num2 * (float)this.nuWcJbFck8r, num2 * (float)this.SqpcJ3aZGGS, num2 * (float)this.nuWcJbFck8r), this.sign);
															if (190643 - 59970 == 130673)
															{
																break;
															}
														}
													}
												}
											}
										}
										else
										{
											this.aZpcJd3Cu7c = Time.time + (float)num * 0.01f;
											if (229821 - 44109 == 185712)
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
	}

	// Token: 0x06005637 RID: 22071 RVA: 0x00A6DA68 File Offset: 0x00A6BC68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005638 RID: 22072 RVA: 0x00A6DA6C File Offset: 0x00A6BC6C
	internal static bool ISZ9kQ54iIlBiWnFUkp4()
	{
		return true;
	}

	// Token: 0x06005639 RID: 22073 RVA: 0x00A6DA70 File Offset: 0x00A6BC70
	internal static bool mAsJqZ54K5PdlEuv5AK5()
	{
		return false;
	}

	// Token: 0x04005EF5 RID: 24309
	public string command;

	// Token: 0x04005EF6 RID: 24310
	public Texture sign;

	// Token: 0x04005EF7 RID: 24311
	private int SqpcJ3aZGGS;

	// Token: 0x04005EF8 RID: 24312
	private int nuWcJbFck8r;

	// Token: 0x04005EF9 RID: 24313
	private float aZpcJd3Cu7c;
}
