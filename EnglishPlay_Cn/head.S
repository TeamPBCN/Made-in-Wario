#define FUNC(name) \
	.global name; \
	.type name, %function; \
name:

.section .text
.arm

_text_start:

#if 0
FUNC(jmp_sub_100C54)
    LDR             PC, sub_100C54
sub_100C54:
.word 0x100C55

FUNC(call_hook_sub_100C54)
    BL              hook_sub_100C54
    MOV             R0, R4
    LDR             PC, lbl_50401C
lbl_50401C:
.word 0x50401C
#endif

FUNC(jmp_get_pronun)
    SUB             R0, R0, #0x3000
    SUB             R0, R0, #0x42
    LDR             PC, get_pronun
get_pronun:
.word 0x49008C

FUNC(jmp_hook_get_pronun)
    LDR             PC, =hook_get_pronun
