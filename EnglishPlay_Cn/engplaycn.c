#include "char_table.h"


char * hook_get_pronun(wchar_t const c)
{
    char *result = 0;
    int i;

    for(i = 0; i < sizeof(charTable)/sizeof(CharTableEntry); i++){
        if(charTable[i]._char == c){
            result = &charTable[i].pronun;
            break;
        }
    }
    if (result)
        return result;
    else
        return jmp_get_pronun(c);
}