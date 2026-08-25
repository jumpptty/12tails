using System;

// Token: 0x02001072 RID: 4210
[Serializable]
public enum eLoginState
{
	// Token: 0x04006F4E RID: 28494
	Init,
	// Token: 0x04006F4F RID: 28495
	intro,
	// Token: 0x04006F50 RID: 28496
	fadeIn,
	// Token: 0x04006F51 RID: 28497
	nProtect,
	// Token: 0x04006F52 RID: 28498
	serverSelect,
	// Token: 0x04006F53 RID: 28499
	login,
	// Token: 0x04006F54 RID: 28500
	loginServer,
	// Token: 0x04006F55 RID: 28501
	loginFail,
	// Token: 0x04006F56 RID: 28502
	realmSelect,
	// Token: 0x04006F57 RID: 28503
	connecting,
	// Token: 0x04006F58 RID: 28504
	connected,
	// Token: 0x04006F59 RID: 28505
	serverDown,
	// Token: 0x04006F5A RID: 28506
	serverEnter,
	// Token: 0x04006F5B RID: 28507
	noPlayerData,
	// Token: 0x04006F5C RID: 28508
	createPlayerData,
	// Token: 0x04006F5D RID: 28509
	createPlayerWait,
	// Token: 0x04006F5E RID: 28510
	createPlayerSuccess,
	// Token: 0x04006F5F RID: 28511
	createPlayerFail,
	// Token: 0x04006F60 RID: 28512
	join,
	// Token: 0x04006F61 RID: 28513
	loading,
	// Token: 0x04006F62 RID: 28514
	error
}
