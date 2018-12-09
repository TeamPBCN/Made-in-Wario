typedef unsigned int u32;
typedef signed int s32;
typedef s32 Result;
typedef unsigned short u16;
typedef u16 wchar_t;

#define ROMFS_ARCHIVE_OPENFILE_SUCCESS 0

typedef Result (*RomFsArchive$$OpenFile_t)(void*, void**, u32*, u32);
typedef void* (*FindArchive_t)(wchar_t const*);

/// The following two address is different between games. Find it for yourself.
static const RomFsArchive$$OpenFile_t RomFsArchive$$OpenFile = *(RomFsArchive$$OpenFile_t)0x0030FA78;
static const FindArchive_t FindArchive = *(FindArchive_t)0x0018147C;

Result hook_RomFsArchive$$OpenFile(void * thisptr, void ** ifile, u32 * pathObject, u32 mode)
{
	static void * exRomArcObj = 0;
	if (!exRomArcObj)
	{
		/// Find the extra ROM objet by mount point.
		/// The mount point may different in other games. Just search it in the code.
		exRomArcObj = FindArchive(L"patch:/");
	}
	if(exRomArcObj)
	{
		if(RomFsArchive$$OpenFile(exRomArcObj, ifile, pathObject, mode) == ROMFS_ARCHIVE_OPENFILE_SUCCESS) 
			return ROMFS_ARCHIVE_OPENFILE_SUCCESS;
	}
	return RomFsArchive$$OpenFile(thisptr, ifile, pathObject, mode);
}
