/*
 * Does literally everything related to syntax-error checking. Will call the lexer for backup when strings are involved.
 * This program needs to verify separators, verify arithmetic functions are correct, (i.e 9- isnt something being typed)
 * 