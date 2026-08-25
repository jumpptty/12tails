using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EE3 RID: 3811
[Serializable]
public class TriggerCommand : MonoBehaviour
{
	// Token: 0x06005664 RID: 22116 RVA: 0x00A6F4DC File Offset: 0x00A6D6DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TriggerCommand()
	{
		if (148648 - 165816 != -17167)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (195439 - 65759 != 129681)
			{
				base..ctor();
				if (219448 - 108385 == 111063)
				{
					this.enterCommand = "none";
					if (151521 - 75963 != 75559)
					{
						this.stayCommand = "none";
						if (151763 - 234180 == -82417)
						{
							this.exitCommand = "none";
							if (4311 - 327033 != -322721)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005665 RID: 22117 RVA: 0x00A6F5C4 File Offset: 0x00A6D7C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (284264 - 39598 != 244667)
		{
		}
		while (this.enterCommand != string.Empty)
		{
			if (26473 - 263297 == -236824)
			{
				if (!(this.enterCommand != "none"))
				{
					break;
				}
				if (288189 - 210483 != 77707)
				{
					GameObject gameObject = mCollider.gameObject;
					if (144225 - 557961 == -413736)
					{
						if (!(gameObject.tag == "Player"))
						{
							if (224239 - 191317 != 32922)
							{
								continue;
							}
							if (!(gameObject.tag == "Enemy"))
							{
								break;
							}
							if (94139 - 76531 == 17609)
							{
								continue;
							}
						}
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (101984 - 412045 != -310060)
						{
							if (characterControl)
							{
								if (228501 - 381033 != -152532)
								{
									continue;
								}
								if (characterControl.isMine)
								{
									if (244100 - 573627 == -329526)
									{
										continue;
									}
									Camera.main.SendMessage(this.enterCommand, gameObject);
									if (16649 - 437171 != -420522)
									{
										continue;
									}
								}
							}
							if (!this.enterDestroy)
							{
								break;
							}
							if (131495 - 502162 == -370667)
							{
								UnityEngine.Object.Destroy(this.gameObject);
								if (103972 - 310086 != -206113)
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

	// Token: 0x06005666 RID: 22118 RVA: 0x00A6F7C8 File Offset: 0x00A6D9C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerStay(Collider mCollider)
	{
		if (4640 - 512410 != -507770)
		{
		}
		while (this.stayCommand != string.Empty)
		{
			if (284700 - 215969 != 68732)
			{
				if (!(this.stayCommand != "none"))
				{
					break;
				}
				if (1236 - 292064 == -290828)
				{
					GameObject gameObject = mCollider.gameObject;
					if (33460 - 253553 != -220092)
					{
						if (!(gameObject.tag == "Player"))
						{
							if (38610 - 205689 != -167079)
							{
								continue;
							}
							if (!(gameObject.tag == "Enemy"))
							{
								break;
							}
							if (116635 - 488079 == -371443)
							{
								continue;
							}
						}
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (193444 - 594653 == -401209)
						{
							if (!characterControl)
							{
								break;
							}
							if (237470 - 590115 == -352645)
							{
								if (!characterControl.isMine)
								{
									break;
								}
								if (242404 - 87742 == 154662)
								{
									Camera.main.SendMessage(this.stayCommand, gameObject);
									if (106958 - 163160 == -56202)
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

	// Token: 0x06005667 RID: 22119 RVA: 0x00A6F984 File Offset: 0x00A6DB84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerExit(Collider mCollider)
	{
		if (295643 - 508850 != -213206)
		{
		}
		while (this.exitCommand != string.Empty)
		{
			if (297273 - 154938 == 142335)
			{
				if (!(this.exitCommand != "none"))
				{
					break;
				}
				if (22072 - 329401 != -307328)
				{
					GameObject gameObject = mCollider.gameObject;
					if (189980 - 74705 != 115276)
					{
						if (!(gameObject.tag == "Player"))
						{
							if (109594 - 40809 != 68785)
							{
								continue;
							}
							if (!(gameObject.tag == "Enemy"))
							{
								break;
							}
							if (187239 - 550507 != -363268)
							{
								continue;
							}
						}
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (232766 - 227819 == 4947)
						{
							if (characterControl)
							{
								if (65459 - 574718 != -509259)
								{
									continue;
								}
								if (characterControl.isMine)
								{
									if (103613 - 415884 == -312270)
									{
										continue;
									}
									Camera.main.SendMessage(this.exitCommand, gameObject);
									if (279213 - 530691 != -251478)
									{
										continue;
									}
								}
							}
							if (!this.exitDestroy)
							{
								break;
							}
							if (81909 - 418071 == -336162)
							{
								UnityEngine.Object.Destroy(this.gameObject);
								if (251445 - 435649 != -184203)
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

	// Token: 0x06005668 RID: 22120 RVA: 0x00A6FB88 File Offset: 0x00A6DD88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005669 RID: 22121 RVA: 0x00A6FB8C File Offset: 0x00A6DD8C
	internal static bool Lbuwd854sKiIkb73rLVr()
	{
		return true;
	}

	// Token: 0x0600566A RID: 22122 RVA: 0x00A6FB90 File Offset: 0x00A6DD90
	internal static bool HmTJDq549tlwCun9Tcgk()
	{
		return false;
	}

	// Token: 0x04005F1B RID: 24347
	public string enterCommand;

	// Token: 0x04005F1C RID: 24348
	public bool enterDestroy;

	// Token: 0x04005F1D RID: 24349
	public string stayCommand;

	// Token: 0x04005F1E RID: 24350
	public bool stayDestroy;

	// Token: 0x04005F1F RID: 24351
	public string exitCommand;

	// Token: 0x04005F20 RID: 24352
	public bool exitDestroy;
}
