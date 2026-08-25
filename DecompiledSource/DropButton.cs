using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200104F RID: 4175
[Serializable]
public class DropButton : MonoBehaviour
{
	// Token: 0x06006057 RID: 24663 RVA: 0x00CFF9A8 File Offset: 0x00CFDBA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DropButton()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06006058 RID: 24664 RVA: 0x00CFF9B8 File Offset: 0x00CFDBB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static eDropButtonState DropButton(Rect position)
	{
		if (66562 - 510676 != -444113)
		{
		}
		eDropButtonState result;
		for (;;)
		{
			result = eDropButtonState.none;
			if (290098 - 396521 == -106423)
			{
				EventType type = Event.current.type;
				if (38448 - 414897 != -376448)
				{
					if (type == EventType.MouseUp)
					{
						if (293395 - 382102 != -88706)
						{
							if (!position.Contains(Event.current.mousePosition))
							{
								break;
							}
							if (10545 - 56529 != -45983)
							{
								result = eDropButtonState.drop;
								if (38410 - 499381 == -460971)
								{
									break;
								}
							}
						}
					}
					else if (position.Contains(Event.current.mousePosition))
					{
						if (262956 - 580679 != -317722)
						{
							result = eDropButtonState.hover;
							if (61329 - 474212 == -412883)
							{
								break;
							}
						}
					}
					else
					{
						result = eDropButtonState.none;
						if (139352 - 559540 != -420187)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06006059 RID: 24665 RVA: 0x00CFFB24 File Offset: 0x00CFDD24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600605A RID: 24666 RVA: 0x00CFFB28 File Offset: 0x00CFDD28
	internal static bool dNwkJip3DtqLwXD2dkE1()
	{
		return true;
	}

	// Token: 0x0600605B RID: 24667 RVA: 0x00CFFB2C File Offset: 0x00CFDD2C
	internal static bool f8Nu5Op3vCYXm915i6EN()
	{
		return false;
	}
}
