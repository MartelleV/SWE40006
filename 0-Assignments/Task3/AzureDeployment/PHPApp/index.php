<?php
/**
 * StudentPortfolio - Main Entry Point
 * PHP translation of ASP.NET Core MVC application
 */

// Load configuration
require_once 'config.php';

// Simple routing with security validation
$page = $_GET['page'] ?? 'home';
$action = $_GET['action'] ?? 'index';

// Validate input to prevent directory traversal
if (!in_array($page, ALLOWED_PAGES) || !in_array($action, ALLOWED_ACTIONS)) {
    $page = 'error';
    $action = 'error';
}

// Student data
$studentName = STUDENT_NAME;
$studentID = STUDENT_ID;
$unit = UNIT_NAME;
$skills = ["C#", "ASP.NET Core", "Azure", "PHP"];

// Route to appropriate controller
if ($page === 'home' && $action === 'index') {
    $pageTitle = "Student Portfolio";
    include 'views/home/index.php';
} elseif ($page === 'home' && $action === 'music') {
    $pageTitle = "My Music";
    include 'controllers/music_controller.php';
    include 'views/home/music.php';
} else {
    $pageTitle = "Error";
    $requestId = uniqid();
    include 'views/shared/error.php';
}
?>
