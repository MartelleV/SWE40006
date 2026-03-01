<?php
/**
 * Centralized image path configuration for music-related images.
 * Image naming convention: all lowercase, spaces replaced with hyphens, and special characters removed.
 */

function sanitizeFileName($name) {
    return strtolower(
        str_replace(
            ["'", "&", ",", ".", " "],
            ["", "and", "", "", "-"],
            $name
        )
    );
}

function getArtistImage($artistName) {
    $fileName = sanitizeFileName($artistName);
    return "assets/images/music/artists/{$fileName}.webp";
}

function getAlbumImage($albumTitle) {
    $fileName = sanitizeFileName($albumTitle);
    return "assets/images/music/albums/{$fileName}.webp";
}
?>
