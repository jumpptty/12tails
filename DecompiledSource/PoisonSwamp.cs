using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EEE RID: 3822
[Serializable]
public class PoisonSwamp : MonoBehaviour
{
	// Token: 0x060056B5 RID: 22197 RVA: 0x00A736A8 File Offset: 0x00A718A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PoisonSwamp()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060056B6 RID: 22198 RVA: 0x00A736B8 File Offset: 0x00A718B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		this.renderer.material.SetTextureOffset("_MainTex", new Vector2(Mathf.Repeat(Time.time * 0.02f, (float)100), (float)0));
	}

	// Token: 0x060056B7 RID: 22199 RVA: 0x00A736EC File Offset: 0x00A718EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (97225 - 297919 != -200693)
		{
		}
		for (;;)
		{
			GameObject gameObject = mCollider.gameObject;
			if (208975 - 207112 != 1864)
			{
				if (!(gameObject.tag == "Player"))
				{
					if (259092 - 573988 != -314896)
					{
						continue;
					}
					if (!(gameObject.tag == "Enemy"))
					{
						break;
					}
					if (80818 - 84544 == -3725)
					{
						continue;
					}
				}
				CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
				if (260701 - 80529 == 180172)
				{
					if (!characterControl)
					{
						break;
					}
					if (243199 - 396111 == -152912)
					{
						if (!characterControl.isMine)
						{
							break;
						}
						if (231092 - 124355 != 106738)
						{
							int debuff = Damage.getDebuff((float)12, 32, characterControl.cha);
							if (243240 - 369782 == -126542)
							{
								characterControl.RPC_AddStatus("poison", 2, debuff, 0, characterControl.ActorNr);
								if (265149 - 397015 == -131866)
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

	// Token: 0x060056B8 RID: 22200 RVA: 0x00A73878 File Offset: 0x00A71A78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060056B9 RID: 22201 RVA: 0x00A7387C File Offset: 0x00A71A7C
	internal static bool OFdntE5zAkcDNS2mje98()
	{
		return true;
	}

	// Token: 0x060056BA RID: 22202 RVA: 0x00A73880 File Offset: 0x00A71A80
	internal static bool G2c6GL5zlc31gTFCACIo()
	{
		return false;
	}
}
