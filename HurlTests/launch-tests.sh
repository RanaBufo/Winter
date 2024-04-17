#!/bin/bash

export HURL_HOST=http://localhost:5173

# hurl ./flushdb.hurl
hurl --glob ./main_tests/**.hurl --test $1 $2
