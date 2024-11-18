<?php

use App\EvenNumberEvaluator;
use App\FileLogger;

require_once '../vendor/autoload.php';

$logger = new FileLogger('../application.log');
if ( ! isset($_GET['number'])) {
    $logger->log('Number is not provided', 'error');
    exit(1);
}

$digit = $_GET['number'];

$evenEvaluator = new EvenNumberEvaluator();
$message = $evenEvaluator->evaluate($digit)
    ? sprintf('%d is even', $digit)
    : sprintf('%d is odd', $digit);
$logger->log($message, 'info');
