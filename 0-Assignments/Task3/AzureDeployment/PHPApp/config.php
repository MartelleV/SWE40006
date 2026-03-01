<?php
/**
 * Application Configuration
 */

// Error reporting (set to 0 in production)
error_reporting(E_ALL);
ini_set('display_errors', 1);

// Timezone
date_default_timezone_set('UTC');

// Application settings
define('APP_NAME', 'StudentPortfolio');
define('APP_VERSION', '1.0.0');

// Student information
define('STUDENT_NAME', 'Vu Phan Hoang An');
define('STUDENT_ID', '104775412');
define('UNIT_NAME', 'SWE40006 Software Deployment and Evolution');

// Paths
define('BASE_PATH', __DIR__);
define('ASSETS_PATH', '/assets');
define('VIEWS_PATH', BASE_PATH . '/views');
define('CONTROLLERS_PATH', BASE_PATH . '/controllers');
define('HELPERS_PATH', BASE_PATH . '/helpers');

// Security
define('ALLOWED_PAGES', ['home']);
define('ALLOWED_ACTIONS', ['index', 'music']);
?>
