<?php

namespace App;

interface LoggerInterface
{
    /**
     * Log message with given level of severity
     *
     * @param string $message Message text
     * @param string $level Message severity level
     * @return void
     */
    public function log(string $message, string $level): void;
}