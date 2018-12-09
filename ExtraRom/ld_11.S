OUTPUT_FORMAT("elf32-littlearm", "elf32-littlearm", "elf32-littlearm")
OUTPUT_ARCH(arm)

ENTRY(_start)

SECTIONS
{
  . = 0x00799CC0;
  .text       : { *(.text) }
  .rodata     : { *(.rodata) }
  .data       : { *(.data) }
  . = 0x009617E4;
  .bss        : { *(.bss) }
}