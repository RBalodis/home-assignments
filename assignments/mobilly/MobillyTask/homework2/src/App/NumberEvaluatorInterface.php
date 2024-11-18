<?php

namespace App;

interface NumberEvaluatorInterface
{
    /**
     * Performs digit evaluation
     *
     * @param int $digit Digit to evaluate
     * @return void
     */
    public function evaluate(int $digit): bool;
}