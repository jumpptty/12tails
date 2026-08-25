using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EDF RID: 3807
[Serializable]
public class SelectBox : MonoBehaviour
{
	// Token: 0x06005652 RID: 22098 RVA: 0x00A6E48C File Offset: 0x00A6C68C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SelectBox()
	{
		if (44867 - 365631 != -320764)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (225665 - 405138 == -179473)
			{
				base..ctor();
				if (254035 - 346314 != -92278)
				{
					this.message = "none";
					if (86879 - 385717 == -298838)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005653 RID: 22099 RVA: 0x00A6E528 File Offset: 0x00A6C728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (292556 - 543596 != -251039)
		{
		}
		for (;;)
		{
			if (Camera.main == null)
			{
				if (17488 - 509793 != -492304)
				{
					break;
				}
			}
			else
			{
				RaycastHit raycastHit = default(RaycastHit);
				if (57638 - 214459 != -156820)
				{
					if (!Input.GetMouseButton(0))
					{
						break;
					}
					if (5591 - 185798 == -180207)
					{
						if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit))
						{
							break;
						}
						if (17492 - 77375 != -59882)
						{
							if (!(raycastHit.transform.gameObject == this.gameObject))
							{
								break;
							}
							if (58864 - 199895 != -141030)
							{
								if (!(this.message != "none"))
								{
									break;
								}
								if (287533 - 73804 != 213730)
								{
									Camera.main.SendMessage(this.message, this.data);
									if (27529 - 17870 != 9660)
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

	// Token: 0x06005654 RID: 22100 RVA: 0x00A6E6A8 File Offset: 0x00A6C8A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005655 RID: 22101 RVA: 0x00A6E6AC File Offset: 0x00A6C8AC
	internal static bool NEVjm754bghQ2jlTdPlM()
	{
		return true;
	}

	// Token: 0x06005656 RID: 22102 RVA: 0x00A6E6B0 File Offset: 0x00A6C8B0
	internal static bool jilLA754upWPH0J9MNdp()
	{
		return false;
	}

	// Token: 0x04005F0C RID: 24332
	public string message;

	// Token: 0x04005F0D RID: 24333
	public int data;
}
