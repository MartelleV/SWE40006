<?php include 'views/shared/header.php'; ?>

<section class="hero-section fade-in">
    <div class="hero-avatar">
        <span class="avatar-initials">VPHA</span>
    </div>
    <h1 class="hero-name"><?php echo htmlspecialchars($studentName); ?></h1>
    <p class="hero-subtitle"><?php echo htmlspecialchars($studentID); ?></p>
    <p class="hero-unit"><?php echo htmlspecialchars($unit); ?></p>
</section>

<div class="row g-4 fade-in delay-1">
    <div class="col-12">
        <div class="info-card">
            <h4>Technical Skills</h4>
            <div class="skills-grid">
                <?php foreach ($skills as $skill): ?>
                    <span class="skill-badge"><?php echo htmlspecialchars($skill); ?></span>
                <?php endforeach; ?>
            </div>
        </div>
    </div>
    <div class="col-12">
        <div class="info-card status-card">
            <div class="status-icon">
                <svg width="20" height="20" viewBox="0 0 20 20" fill="none">
                    <path d="M10 2L3 7V13C3 16.31 5.69 19.31 10 20C14.31 19.31 17 16.31 17 13V7L10 2Z"
                          stroke="currentColor" stroke-width="1.5" stroke-linecap="round" stroke-linejoin="round" />
                    <path d="M7.5 10L9.5 12L12.5 8.5" stroke="currentColor" stroke-width="1.5" stroke-linecap="round"
                          stroke-linejoin="round" />
                </svg>
            </div>
            <div class="status-content">
                <h4>Deployment Status</h4>
                <div class="status-banner">
                    <span class="status-dot"></span>
                    <span>Deployed to Microsoft Azure - SWE40006 Task 3</span>
                </div>
            </div>
        </div>
    </div>
</div>

<?php include 'views/shared/footer.php'; ?>
