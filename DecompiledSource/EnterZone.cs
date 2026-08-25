using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000ED8 RID: 3800
[Serializable]
public class EnterZone : MonoBehaviour
{
	// Token: 0x0600562C RID: 22060 RVA: 0x00A6D394 File Offset: 0x00A6B594
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnterZone()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600562D RID: 22061 RVA: 0x00A6D3A4 File Offset: 0x00A6B5A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (54605 - 146835 != -92230)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (16006 - 540367 != -524360)
				{
					break;
				}
			}
			else
			{
				if (!(this.command != string.Empty))
				{
					break;
				}
				if (2159 - 173255 == -171096)
				{
					GameObject gameObject = mCollider.gameObject;
					if (162064 - 130318 == 31746)
					{
						if (!(gameObject.tag == "Player"))
						{
							if (43115 - 570999 == -527883)
							{
								continue;
							}
							if (!(gameObject.tag == "Enemy"))
							{
								break;
							}
							if (77572 - 117594 == -40021)
							{
								continue;
							}
						}
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (139399 - 387715 == -248316)
						{
							if (!characterControl)
							{
								break;
							}
							if (137658 - 379507 == -241849)
							{
								if (!characterControl.isMine)
								{
									break;
								}
								if (42113 - 546612 != -504498)
								{
									Camera.main.SendMessage(this.command, gameObject);
									if (82514 - 65199 != 17316)
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

	// Token: 0x0600562E RID: 22062 RVA: 0x00A6D55C File Offset: 0x00A6B75C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600562F RID: 22063 RVA: 0x00A6D560 File Offset: 0x00A6B760
	internal static bool prWfIh54num1e5ECc55V()
	{
		return true;
	}

	// Token: 0x06005630 RID: 22064 RVA: 0x00A6D564 File Offset: 0x00A6B764
	internal static bool lUJKWU5469usMYsydiBX()
	{
		return false;
	}

	// Token: 0x04005EF4 RID: 24308
	public string command;
}
