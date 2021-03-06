ifeq ($(strip $(DEVKITARM)),)
$(error "Please set DEVKITARM in your environment. export DEVKITARM=<path to>devkitARM")
endif

include $(DEVKITARM)/3ds_rules

PREFIX ?= arm-none-eabi-

LD := $(PREFIX)gcc
OBJDUMP = $(PREFIX)objdump

# define options for compilation
CFLAGS = -Wall -Os -fno-builtin -march=armv6k -fshort-wchar -D_3DS -mthumb
CFLAGS += -Ilibctru

# define options for linkage. Prevent the inclusion of standard start
# code and libraries.
LDFLAGS = -fno-builtin -nostartfiles -nodefaultlibs -Wl,--use-blx


# define options for the objdump
DUMPFLAGS = -xdsS

# use variables to refer to init code in case it changes
OBJS = engplaycn.o head.o

#
# define build targets
#
all: payload.bin


prepare: char_table.h 
	python ../sarc/sarc.py -xvf Lyt.arc


clean:
	rm -f *.o *.elf *.bin *.dump


# build s-record with init code and c files linked together
payload.bin: $(OBJS)
	$(LD) $(LDFLAGS) -T ld_11.S -o payload.elf $(OBJS) $(LIBS)
	$(OBJDUMP) $(DUMPFLAGS) payload.elf > payload.dump
	$(OBJCOPY) -O binary payload.elf payload.bin

# handle compilation of C files
%.o:%.S
	$(CC) -D__ASSEMBLY__ $(CFLAGS) $(CFLAGS_$*) -c $< -o $@

%.o: %.c
	$(CC) $(CFLAGS) $(CFLAGS_$*) -c $< -o $@

char_table.h: chars.txt
	python ./gen_char_table.py DrawAll $<

chars.txt: ./Data/Words.txt
	python ../xlltgen/xlltgen.py -f $^ -x $@