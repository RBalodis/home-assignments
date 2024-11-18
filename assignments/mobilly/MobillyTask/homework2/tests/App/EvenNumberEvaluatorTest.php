<?php

namespace App;

use PHPUnit\Framework\TestCase;

class EvenNumberEvaluatorTest extends TestCase
{
    public function testEvaluate()
    {
        $evaluator = new EvenNumberEvaluator();
        $this->assertTrue($evaluator->evaluate(2));
        $this->assertTrue($evaluator->evaluate(16));
        $this->assertFalse($evaluator->evaluate(1));
        $this->assertFalse($evaluator->evaluate(3));
    }
}
