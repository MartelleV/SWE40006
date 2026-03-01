<?php 
include 'helpers/image_helper.php';
include 'views/shared/header.php'; 
?>

<section class="music-hero fade-in">
    <div class="music-hero-icon">♫</div>
    <h1 class="page-title">My Music</h1>
    <p class="page-subtitle">A curated collection of my musical favorites</p>
</section>

<div class="music-tabs fade-in delay-1">
    <ul class="nav nav-pills mb-4" id="musicTabs" role="tablist">
        <li class="nav-item" role="presentation">
            <button class="nav-link active" id="genres-tab" data-bs-toggle="pill"
                    data-bs-target="#genres" type="button" role="tab"
                    aria-controls="genres" aria-selected="true">
                <span>Genres</span>
            </button>
        </li>
        <li class="nav-item" role="presentation">
            <button class="nav-link" id="artists-tab" data-bs-toggle="pill"
                    data-bs-target="#artists" type="button" role="tab"
                    aria-controls="artists" aria-selected="false">
                <span>Artists</span>
            </button>
        </li>
        <li class="nav-item" role="presentation">
            <button class="nav-link" id="songs-tab" data-bs-toggle="pill"
                    data-bs-target="#songs" type="button" role="tab"
                    aria-controls="songs" aria-selected="false">
                <span>Songs</span>
            </button>
        </li>
        <li class="nav-item" role="presentation">
            <button class="nav-link" id="albums-tab" data-bs-toggle="pill"
                    data-bs-target="#albums" type="button" role="tab"
                    aria-controls="albums" aria-selected="false">
                <span>Albums</span>
            </button>
        </li>
    </ul>

    <div class="tab-content" id="musicTabsContent">

        <!-- Genres -->
        <div class="tab-pane fade show active" id="genres" role="tabpanel" aria-labelledby="genres-tab">
            <div class="row g-4">
                <?php
                $genreEmoji = [
                    "Rock" => "🎸", "Blues" => "🎵",
                    "Jazz" => "🎷", "Dance" => "🎧"
                ];
                $genreColors = [
                    "Rock" => "#ef4444", "Blues" => "#3b82f6",
                    "Jazz" => "#f59e0b", "Dance" => "#a78bfa"
                ];
                $genreDescriptions = [
                    "Rock" => "Hard Rock & Progressive Rock",
                    "Blues" => "Blues & Soul",
                    "Jazz" => "Jazz & Fusion",
                    "Dance" => "Electronic & Dance"
                ];
                
                foreach ($genres as $genre):
                    $color = $genreColors[$genre] ?? "#a78bfa";
                    $icon = $genreEmoji[$genre] ?? "🎵";
                    $description = $genreDescriptions[$genre] ?? "Music Genre";
                ?>
                    <div class="col-6 col-md-3">
                        <div class="genre-card" style="--genre-color: <?php echo $color; ?>">
                            <span class="genre-icon"><?php echo $icon; ?></span>
                            <h3 class="genre-name"><?php echo htmlspecialchars($genre); ?></h3>
                            <p class="genre-description"><?php echo htmlspecialchars($description); ?></p>
                        </div>
                    </div>
                <?php endforeach; ?>
            </div>
        </div>

        <!-- Artists -->
        <div class="tab-pane fade" id="artists" role="tabpanel" aria-labelledby="artists-tab">
            <div class="row g-3">
                <?php foreach ($artists as $artist): 
                    $nameForInit = str_starts_with($artist['name'], 'The ') 
                        ? substr($artist['name'], 4) 
                        : $artist['name'];
                    $parts = explode(' ', trim($nameForInit));
                    $initials = count($parts) >= 2
                        ? strtoupper($parts[0][0] . $parts[count($parts) - 1][0])
                        : strtoupper(substr($nameForInit, 0, min(2, strlen($nameForInit))));
                    $imagePath = getArtistImage($artist['name']);
                ?>
                    <div class="col-12 col-sm-6 col-lg-4">
                        <div class="music-card artist-card">
                            <div class="artist-image-wrapper">
                                <img src="<?php echo htmlspecialchars($imagePath); ?>" 
                                     alt="<?php echo htmlspecialchars($artist['name']); ?>" 
                                     class="artist-image"
                                     onerror="this.style.display='none'; this.nextElementSibling.style.display='flex';" />
                                <div class="artist-avatar" style="display: none;"><?php echo $initials; ?></div>
                            </div>
                            <div class="music-card-info">
                                <h4 class="music-card-title"><?php echo htmlspecialchars($artist['name']); ?></h4>
                                <span class="music-card-subtitle"><?php echo htmlspecialchars($artist['genre']); ?></span>
                            </div>
                        </div>
                    </div>
                <?php endforeach; ?>
            </div>
        </div>

        <!-- Songs -->
        <div class="tab-pane fade" id="songs" role="tabpanel" aria-labelledby="songs-tab">
            <div class="row g-3">
                <?php 
                $songIdx = 1;
                foreach ($songs as $song): 
                ?>
                    <div class="col-12 col-md-6">
                        <div class="music-card song-card">
                            <span class="song-number"><?php echo str_pad($songIdx, 2, '0', STR_PAD_LEFT); ?></span>
                            <div class="song-play-icon">
                                <svg width="16" height="16" viewBox="0 0 16 16" fill="currentColor">
                                    <path d="M3 2.5v11l10-5.5L3 2.5z"/>
                                </svg>
                            </div>
                            <div class="music-card-info">
                                <h4 class="music-card-title"><?php echo htmlspecialchars($song['title']); ?></h4>
                                <span class="music-card-subtitle"><?php echo htmlspecialchars($song['artist']); ?></span>
                            </div>
                        </div>
                    </div>
                <?php 
                    $songIdx++;
                endforeach; 
                ?>
            </div>
        </div>

        <!-- Albums -->
        <div class="tab-pane fade" id="albums" role="tabpanel" aria-labelledby="albums-tab">
            <div class="row g-4">
                <?php foreach ($albums as $album): 
                    $imagePath = getAlbumImage($album['title']);
                ?>
                    <div class="col-6 col-sm-4 col-lg-3">
                        <div class="album-card">
                            <div class="album-cover-wrapper">
                                <img src="<?php echo htmlspecialchars($imagePath); ?>" 
                                     alt="<?php echo htmlspecialchars($album['title']); ?>" 
                                     class="album-cover"
                                     onerror="this.style.display='none'; this.nextElementSibling.style.display='flex';" />
                                <div class="album-art-placeholder" style="display: none;">♫</div>
                            </div>
                            <div class="album-info">
                                <h4 class="album-title"><?php echo htmlspecialchars($album['title']); ?></h4>
                                <span class="album-artist"><?php echo htmlspecialchars($album['artist']); ?></span>
                            </div>
                        </div>
                    </div>
                <?php endforeach; ?>
            </div>
        </div>

    </div>
</div>

<?php include 'views/shared/footer.php'; ?>
