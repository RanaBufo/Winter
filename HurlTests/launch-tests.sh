#!/bin/bash

export HURL_HOST=http://localhost:5214

# hurl ./flushdb.hurl
hurl --glob ./main_tests/**.hurl --test $1 $2
