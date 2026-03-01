<?php
/**
 * Music Controller - Database Version
 * Use this instead of music_controller.php if you want to use MySQL database
 */

require_once 'database/db_config.php';

try {
    $db = getDbConnection();
    
    // Fetch genres
    $stmt = $db->query("SELECT name FROM genres ORDER BY name");
    $genres = $stmt->fetchAll(PDO::FETCH_COLUMN);
    
    // Fetch artists
    $stmt = $db->query("SELECT name, genre FROM artists ORDER BY name");
    $artists = $stmt->fetchAll();
    
    // Fetch songs
    $stmt = $db->query("SELECT title, artist FROM songs ORDER BY id");
    $songs = $stmt->fetchAll();
    
    // Fetch albums
    $stmt = $db->query("SELECT title, artist FROM albums ORDER BY id");
    $albums = $stmt->fetchAll();
    
} catch (PDOException $e) {
    error_log("Database query failed: " . $e->getMessage());
    
    // Fallback to in-memory data
    include 'controllers/music_controller.php';
}
?>
