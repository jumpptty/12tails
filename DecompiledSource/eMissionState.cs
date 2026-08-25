using System;

// Token: 0x02001083 RID: 4227
[Serializable]
public enum eMissionState
{
	// Token: 0x04007077 RID: 28791
	init,
	// Token: 0x04007078 RID: 28792
	disabled,
	// Token: 0x04007079 RID: 28793
	open,
	// Token: 0x0400707A RID: 28794
	selectQuest,
	// Token: 0x0400707B RID: 28795
	createQuest,
	// Token: 0x0400707C RID: 28796
	createTeam,
	// Token: 0x0400707D RID: 28797
	joinQuest,
	// Token: 0x0400707E RID: 28798
	joinTeam,
	// Token: 0x0400707F RID: 28799
	matchSearch,
	// Token: 0x04007080 RID: 28800
	matchFound,
	// Token: 0x04007081 RID: 28801
	startQuest,
	// Token: 0x04007082 RID: 28802
	error,
	// Token: 0x04007083 RID: 28803
	close
}
