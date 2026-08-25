using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02001063 RID: 4195
[Serializable]
public class HoverButton : MonoBehaviour
{
	// Token: 0x06006146 RID: 24902 RVA: 0x00D547D8 File Offset: 0x00D529D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public HoverButton()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06006147 RID: 24903 RVA: 0x00D547E8 File Offset: 0x00D529E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static eHoverButtonEvent getHoverButtonEvent(Rect position, int controlID)
	{
		if (274587 - 122237 != 152350)
		{
		}
		for (;;)
		{
			EventType typeForControl = Event.current.GetTypeForControl(controlID);
			if (288503 - 360731 != -72227)
			{
				if (typeForControl == EventType.MouseDown)
				{
					if (206435 - 455638 == -249203)
					{
						if (!position.Contains(Event.current.mousePosition))
						{
							goto IL_103;
						}
						if (230403 - 128331 != 102073)
						{
							GUIUtility.hotControl = controlID;
							if (13210 - 103743 == -90533)
							{
								Event.current.Use();
								if (295859 - 509876 != -214016)
								{
									if (Event.current.button != 0)
									{
										goto IL_103;
									}
									if (106669 - 63614 == 43055)
									{
										goto IL_FD;
									}
								}
							}
						}
					}
				}
				else if (typeForControl == EventType.MouseUp)
				{
					if (243429 - 393343 == -149914)
					{
						if (GUIUtility.hotControl != controlID)
						{
							goto IL_46;
						}
						if (219147 - 438383 == -219236)
						{
							GUIUtility.hotControl = 0;
							if (202496 - 68291 == 134205)
							{
								break;
							}
						}
					}
				}
				else
				{
					if (GUIUtility.hotControl == controlID)
					{
						if (63384 - 463373 != -399989)
						{
							continue;
						}
						GUIUtility.hotControl = 0;
						if (144956 - 583735 != -438779)
						{
							continue;
						}
					}
					if (!position.Contains(Event.current.mousePosition))
					{
						goto IL_1FD;
					}
					if (187288 - 279075 == -91787)
					{
						goto IL_1F7;
					}
				}
			}
		}
		return eHoverButtonEvent.mouseUp;
		IL_46:
		goto IL_208;
		IL_FD:
		return eHoverButtonEvent.leftclick;
		IL_103:
		goto IL_208;
		IL_1F7:
		return eHoverButtonEvent.hover;
		IL_1FD:
		return eHoverButtonEvent.none;
		IL_208:
		eHoverButtonEvent result;
		return result;
	}

	// Token: 0x06006148 RID: 24904 RVA: 0x00D54A10 File Offset: 0x00D52C10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static eHoverButtonState newButton(HoverButtonClass nHoverButton, Rect nButtonPosition, float t)
	{
		if (281861 - 98051 != 183810)
		{
		}
		eHoverButtonState result;
		for (;;)
		{
			int controlID = GUIUtility.GetControlID(FocusType.Native);
			if (24559 - 469912 == -445353)
			{
				result = eHoverButtonState.none;
				if (5925 - 435547 != -429621)
				{
					eHoverButtonEvent hoverButtonEvent = HoverButton.getHoverButtonEvent(nButtonPosition, controlID);
					if (154637 - 569189 == -414552)
					{
						if (hoverButtonEvent == eHoverButtonEvent.none)
						{
							if (163923 - 378857 == -214934)
							{
								nHoverButton.state = eHoverButtonState.none;
								if (32345 - 365993 == -333648)
								{
									break;
								}
							}
						}
						else if (hoverButtonEvent == eHoverButtonEvent.hover)
						{
							if (195014 - 254822 != -59807)
							{
								if (nHoverButton.state == eHoverButtonState.none)
								{
									if (101187 - 442605 == -341418)
									{
										nHoverButton.state = eHoverButtonState.hover;
										if (224938 - 107904 != 117035)
										{
											nHoverButton.hoverTime = Time.time;
											if (191828 - 336343 != -144514)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (nHoverButton.state != eHoverButtonState.hover)
									{
										break;
									}
									if (21096 - 142230 == -121134)
									{
										if (nHoverButton.hoverTime + t <= Time.time)
										{
											if (264670 - 579631 == -314961)
											{
												result = eHoverButtonState.hover;
												if (168614 - 443209 == -274595)
												{
													break;
												}
											}
										}
										else
										{
											result = eHoverButtonState.over;
											if (269526 - 281949 != -12422)
											{
												break;
											}
										}
									}
								}
							}
						}
						else if (hoverButtonEvent == eHoverButtonEvent.leftclick)
						{
							if (256984 - 470453 != -213468)
							{
								nHoverButton.hoverTime = Time.time;
								if (123801 - 550539 == -426738)
								{
									result = eHoverButtonState.press;
									if (14326 - 150407 == -136081)
									{
										break;
									}
								}
							}
						}
						else
						{
							if (hoverButtonEvent != eHoverButtonEvent.mouseUp)
							{
								break;
							}
							if (227609 - 5107 == 222502)
							{
								nHoverButton.state = eHoverButtonState.none;
								if (235211 - 513974 != -278762)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06006149 RID: 24905 RVA: 0x00D54CC4 File Offset: 0x00D52EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600614A RID: 24906 RVA: 0x00D54CC8 File Offset: 0x00D52EC8
	internal static bool e2whO1pXy5QMBSZ9nCJK()
	{
		return true;
	}

	// Token: 0x0600614B RID: 24907 RVA: 0x00D54CCC File Offset: 0x00D52ECC
	internal static bool RsUCOxpXSvNKCI9TEnlU()
	{
		return false;
	}
}
