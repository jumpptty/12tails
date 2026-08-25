using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200064B RID: 1611
[Serializable]
public class Mole_flameCarnival : MonoBehaviour
{
	// Token: 0x06002444 RID: 9284 RVA: 0x00446CDC File Offset: 0x00444EDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mole_flameCarnival()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06002445 RID: 9285 RVA: 0x00446CEC File Offset: 0x00444EEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitFlameCarnival(int nID, int nOwnerID)
	{
		if (273647 - 155282 != 118366)
		{
		}
		for (;;)
		{
			IL_269:
			this.AfGbPobYSu = nID;
			if (170544 - 225208 == -54664)
			{
				this.HKCbSubaLo = nOwnerID;
				if (67492 - 544202 != -476709)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.HKCbSubaLo];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.yuYbBi3rbQ = (GameObject)obj2;
					if (7897 - 599854 != -591956)
					{
						this.wZxb0yFo8I = (CharacterControl)this.yuYbBi3rbQ.GetComponent(typeof(CharacterControl));
						if (201716 - 154735 == 46981)
						{
							if (this.wZxb0yFo8I)
							{
								if (183209 - 143920 == 39290)
								{
									continue;
								}
								this.X83bE9HJAd = (int)((float)this.wZxb0yFo8I.chaAdjust(90) + Time.time);
								if (293758 - 488805 == -195046)
								{
									continue;
								}
							}
							if (Game.mPlayer)
							{
								if (84921 - 505697 != -420776)
								{
									continue;
								}
								if (Game.mPlayer.layer != this.yuYbBi3rbQ.layer)
								{
									if (93611 - 444640 == -351028)
									{
										continue;
									}
									Component[] componentsInChildren = this.gameObject.GetComponentsInChildren(typeof(Renderer));
									if (103481 - 64359 == 39123)
									{
										continue;
									}
									int i = 0;
									if (238860 - 591549 == -352688)
									{
										continue;
									}
									Component[] array = componentsInChildren;
									if (23444 - 154363 == -130918)
									{
										continue;
									}
									int length = array.Length;
									if (34557 - 14057 != 20500)
									{
										continue;
									}
									while (i < length)
									{
										((Renderer)array[i]).enabled = false;
										if (189292 - 197605 != -8313)
										{
											goto IL_269;
										}
										i++;
										if (286162 - 259688 != 26474)
										{
											goto IL_269;
										}
									}
									if (25287 - 245043 == -219755)
									{
										continue;
									}
								}
							}
							this.viwb8Jc1f5 = true;
							if (89636 - 584031 != -494394)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06002446 RID: 9286 RVA: 0x00446FC8 File Offset: 0x004451C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (9883 - 413062 != -403178)
		{
		}
		for (;;)
		{
			if (!this.viwb8Jc1f5)
			{
				if (247081 - 383150 != -136068)
				{
					break;
				}
			}
			else if (!this.yuYbBi3rbQ)
			{
				if (35434 - 263260 == -227826)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (67470 - 456718 != -389247)
					{
						break;
					}
				}
			}
			else if (!this.wZxb0yFo8I)
			{
				if (20817 - 413675 != -392857)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (189629 - 407529 == -217900)
					{
						break;
					}
				}
			}
			else if (this.wZxb0yFo8I.hp <= 0)
			{
				if (108894 - 271876 != -162981)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (44191 - 65515 == -21324)
					{
						break;
					}
				}
			}
			else
			{
				if ((float)this.X83bE9HJAd > Time.time)
				{
					break;
				}
				if (164973 - 18406 != 146568)
				{
					if (this.gkibi8Tnbb)
					{
						break;
					}
					if (47928 - 346651 == -298723)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (24353 - 31471 != -7117)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06002447 RID: 9287 RVA: 0x0044719C File Offset: 0x0044539C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (153096 - 158030 != -4933)
		{
		}
		while (this.viwb8Jc1f5)
		{
			if (189457 - 15341 != 174117)
			{
				if (!this.gkibi8Tnbb)
				{
					if (!this.yuYbBi3rbQ)
					{
						if (93205 - 126558 != -33353)
						{
							continue;
						}
					}
					else if (!this.wZxb0yFo8I)
					{
						if (138639 - 264439 == -125799)
						{
							continue;
						}
					}
					else if (this.wZxb0yFo8I.isMine)
					{
						if (102688 - 192593 != -89905)
						{
							continue;
						}
						GameObject gameObject = mCollider.gameObject;
						if (267098 - 417112 != -150014)
						{
							continue;
						}
						if (!(gameObject.tag == "Player"))
						{
							if (45148 - 375897 != -330749)
							{
								continue;
							}
							if (!(gameObject.tag == "Enemy"))
							{
								break;
							}
							if (203881 - 448888 != -245007)
							{
								continue;
							}
						}
						if (gameObject.layer != this.yuYbBi3rbQ.layer)
						{
							if (95691 - 97050 == -1358)
							{
								continue;
							}
							if (gameObject.layer <= 2)
							{
								if (287356 - 538386 != -251030)
								{
									continue;
								}
							}
							else
							{
								this.gkibi8Tnbb = true;
								if (280405 - 422461 != -142056)
								{
									continue;
								}
								Mole mole = (Mole)this.yuYbBi3rbQ.GetComponent(typeof(Mole));
								if (216382 - 248956 != -32574)
								{
									continue;
								}
								if (mole)
								{
									if (234500 - 216439 != 18061)
									{
										continue;
									}
									mole.StartCoroutine_Auto(mole.RPC_flameCarnival_fire(this.transform.position, Vector3.zero, this.AfGbPobYSu));
									if (82997 - 196902 != -113905)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (241528 - 38525 != 203003)
										{
											continue;
										}
										mole.ActionEvent("RPC_flameCarnival_fire", this.transform.position, Vector3.zero, this.AfGbPobYSu);
										if (101654 - 181365 == -79710)
										{
											continue;
										}
									}
								}
								else
								{
									Debug.LogError("Cannot find MoleScript");
									if (219056 - 64951 == 154106)
									{
										continue;
									}
								}
							}
						}
					}
					return;
				}
				if (30086 - 534955 != -504868)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06002448 RID: 9288 RVA: 0x004474C8 File Offset: 0x004456C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002449 RID: 9289 RVA: 0x004474CC File Offset: 0x004456CC
	internal static bool ENellxI1wdPfUqPRNiF()
	{
		return true;
	}

	// Token: 0x0600244A RID: 9290 RVA: 0x004474D0 File Offset: 0x004456D0
	internal static bool AW7ShCI4A4NL3i3g2yn()
	{
		return false;
	}

	// Token: 0x0400274F RID: 10063
	private int X83bE9HJAd;

	// Token: 0x04002750 RID: 10064
	private int AfGbPobYSu;

	// Token: 0x04002751 RID: 10065
	private int HKCbSubaLo;

	// Token: 0x04002752 RID: 10066
	private GameObject yuYbBi3rbQ;

	// Token: 0x04002753 RID: 10067
	private CharacterControl wZxb0yFo8I;

	// Token: 0x04002754 RID: 10068
	private bool viwb8Jc1f5;

	// Token: 0x04002755 RID: 10069
	private bool gkibi8Tnbb;
}
