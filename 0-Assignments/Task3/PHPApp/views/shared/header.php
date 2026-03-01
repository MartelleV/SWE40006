<!DOCTYPE html>
<html lang="en" data-bs-theme="light">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><?php echo htmlspecialchars($pageTitle ?? 'StudentPortfolio'); ?> — StudentPortfolio</title>
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@300;400;500;600;700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="assets/lib/bootstrap/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="assets/css/site.css" />
</head>
<body>
    <header>
        <nav class="navbar navbar-expand-sm navbar-light sticky-top">
            <div class="container">
                <a class="navbar-brand" href="index.php?page=home&action=index">
                    <span class="brand-icon">◆</span>
                    <span class="brand-text">StudentPortfolio</span>
                </a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target=".navbar-collapse"
                        aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="navbar-collapse collapse d-sm-inline-flex justify-content-end">
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <a class="nav-link" href="index.php?page=home&action=index">Home</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="index.php?page=home&action=music">Music</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </header>

    <div class="page-transition">
        <div class="container">
            <main role="main" class="pb-3">
