typedef unsigned int u32;
typedef signed int s32;
typedef s32 Result;
typedef unsigned short u16;
typedef u16 wchar_t;

typedef struct CharTableEntry_s{
    wchar_t _char;
    char    pronun[6];
}CharTableEntry;
