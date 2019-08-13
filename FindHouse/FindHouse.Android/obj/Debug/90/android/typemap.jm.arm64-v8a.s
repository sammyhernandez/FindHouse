	/* Data SHA1: 8bd6e939f887c18a72a7edb23eea482d0b2b80af */
	.arch	armv8-a
	.file	"typemap.jm.inc"

	/* Mapping header */
	.section	.data.jm_typemap,"aw",@progbits
	.type	jm_typemap_header, @object
	.p2align	2
	.global	jm_typemap_header
jm_typemap_header:
	/* version */
	.word	1
	/* entry-count */
	.word	1343
	/* entry-length */
	.word	262
	/* value-offset */
	.word	117
	.size	jm_typemap_header, 16

	/* Mapping data */
	.type	jm_typemap, @object
	.global	jm_typemap
jm_typemap:
	.size	jm_typemap, 351867
	.include	"typemap.jm.inc"
