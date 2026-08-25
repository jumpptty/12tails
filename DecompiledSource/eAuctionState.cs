using System;

// Token: 0x02001019 RID: 4121
[Serializable]
public enum eAuctionState
{
	// Token: 0x04006931 RID: 26929
	init,
	// Token: 0x04006932 RID: 26930
	open,
	// Token: 0x04006933 RID: 26931
	search,
	// Token: 0x04006934 RID: 26932
	buy,
	// Token: 0x04006935 RID: 26933
	sell,
	// Token: 0x04006936 RID: 26934
	edit,
	// Token: 0x04006937 RID: 26935
	getItem,
	// Token: 0x04006938 RID: 26936
	getMoney,
	// Token: 0x04006939 RID: 26937
	lose,
	// Token: 0x0400693A RID: 26938
	noBid,
	// Token: 0x0400693B RID: 26939
	close,
	// Token: 0x0400693C RID: 26940
	disabled
}
