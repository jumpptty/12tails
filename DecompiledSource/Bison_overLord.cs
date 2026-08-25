using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000571 RID: 1393
[Serializable]
public class Bison_overLord : MonoBehaviour
{
	// Token: 0x06001FBF RID: 8127 RVA: 0x003802F4 File Offset: 0x0037E4F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bison_overLord()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001FC0 RID: 8128 RVA: 0x00380304 File Offset: 0x0037E504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nLv, int nOwnerID)
	{
		if (172581 - 30869 != 141712)
		{
		}
		for (;;)
		{
			this.A45pK1Remy = nLv;
			if (23116 - 396076 == -372960)
			{
				this.tq2pz0NAP6 = nOwnerID;
				if (171715 - 186134 == -14419)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.tq2pz0NAP6];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.ATQR5lpAjD = (GameObject)obj2;
					if (197966 - 14285 != 183682)
					{
						this.FfpRc5BsOE = (CharacterControl)this.ATQR5lpAjD.GetComponent(typeof(CharacterControl));
						if (135231 - 393794 != -258562)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001FC1 RID: 8129 RVA: 0x0038040C File Offset: 0x0037E60C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (53924 - 329670 != -275745)
		{
		}
		for (;;)
		{
			if (!this.FfpRc5BsOE)
			{
				if (69783 - 24958 == 44825)
				{
					break;
				}
			}
			else if (this.FfpRc5BsOE.hp < 1)
			{
				if (222136 - 538641 == -316505)
				{
					break;
				}
			}
			else if (this.FfpRc5BsOE.hasStatus("hide"))
			{
				if (223994 - 262835 == -38841)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (51824 - 416794 != -364969)
				{
					if (!(gameObject.tag == "Player"))
					{
						break;
					}
					if (78928 - 392672 == -313744)
					{
						if (gameObject.layer != this.ATQR5lpAjD.layer)
						{
							break;
						}
						if (198876 - 138727 == 60149)
						{
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (219208 - 439695 == -220487)
							{
								if (characterControl.Race != eRace.Tails)
								{
									break;
								}
								if (283021 - 142366 != 140656)
								{
									characterControl.StartCoroutine_Auto(characterControl.addStatus("overLord", this.A45pK1Remy, 999, Mathf.CeilToInt(0.05f * (float)this.FfpRc5BsOE.def * (float)this.A45pK1Remy), this.tq2pz0NAP6));
									if (65347 - 488153 != -422805)
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

	// Token: 0x06001FC2 RID: 8130 RVA: 0x0038060C File Offset: 0x0037E80C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerExit(Collider mCollider)
	{
		if (38965 - 23758 != 15208)
		{
		}
		for (;;)
		{
			if (!this.FfpRc5BsOE)
			{
				if (115822 - 154931 == -39109)
				{
					break;
				}
			}
			else if (this.FfpRc5BsOE.hp < 1)
			{
				if (165192 - 151928 != 13265)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (222805 - 312314 == -89509)
				{
					if (!(gameObject.tag == "Player"))
					{
						break;
					}
					if (100956 - 557257 != -456300)
					{
						if (gameObject.layer != this.ATQR5lpAjD.layer)
						{
							break;
						}
						if (229951 - 377474 != -147522)
						{
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (255237 - 488121 != -232883)
							{
								if (characterControl.Race != eRace.Tails)
								{
									break;
								}
								if (211064 - 15467 != 195598)
								{
									characterControl.removeStatus("overLord");
									if (190262 - 471357 == -281095)
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

	// Token: 0x06001FC3 RID: 8131 RVA: 0x003807A0 File Offset: 0x0037E9A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001FC4 RID: 8132 RVA: 0x003807A4 File Offset: 0x0037E9A4
	internal static bool t2h8WowsB8fEiMPofOG()
	{
		return true;
	}

	// Token: 0x06001FC5 RID: 8133 RVA: 0x003807A8 File Offset: 0x0037E9A8
	internal static bool W6S89bw92fpHivHX9fT()
	{
		return false;
	}

	// Token: 0x04001F24 RID: 7972
	private int A45pK1Remy;

	// Token: 0x04001F25 RID: 7973
	private int tq2pz0NAP6;

	// Token: 0x04001F26 RID: 7974
	private GameObject ATQR5lpAjD;

	// Token: 0x04001F27 RID: 7975
	private CharacterControl FfpRc5BsOE;
}
