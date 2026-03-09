import sys
import re
from collections import Counter


def analyse(filepath):
    try:
        with open(filepath, "r", encoding="utf-8") as f:
            content = f.read()
    except FileNotFoundError:
        print(f"ERROR: File not found: {filepath}")
        sys.exit(1)

    lines = content.splitlines()
    words = re.findall(r"\b[a-zA-Z']+\b", content.lower())
    sentences = re.split(r"[.!?]+", content)
    sentences = [s.strip() for s in sentences if s.strip()]
    paragraphs = [p.strip() for p in content.split("\n\n") if p.strip()]
    chars_total = len(content)
    chars_no_sp = len(content.replace(" ", "").replace("\n", ""))
    stopwords = {
        "the",
        "a",
        "an",
        "and",
        "or",
        "but",
        "in",
        "on",
        "at",
        "to",
        "for",
        "of",
        "with",
        "is",
        "was",
        "are",
        "were",
        "it",
        "this",
        "that",
        "be",
    }

    filtered = [w for w in words if w not in stopwords and len(w) > 2]
    top10 = Counter(filtered).most_common(10)
    print("=" * 55)
    print(" TEXT FILE ANALYSER — DOCKER EDITION")
    print("=" * 55)
    print(f" File : {filepath}")
    print("-" * 55)
    print(f" Characters : {chars_total:,}")
    print(f" Chars (no sp) : {chars_no_sp:,}")
    print(f" Words : {len(words):,}")
    print(f" Lines : {len(lines):,}")
    print(f" Sentences : {len(sentences):,}")
    print(f" Paragraphs : {len(paragraphs):,}")
    print("-" * 55)
    print(" TOP 10 MOST FREQUENT WORDS (excluding stopwords):")
    print("-" * 55)
    for rank, (word, count) in enumerate(top10, 1):
        bar = "#" * min(count, 30)
        print(f" {rank:>2}. {word:<18} {count:>4} {bar}")
    print("=" * 55)


if __name__ == "__main__":
    if len(sys.argv) < 2:
        print("Usage: python analyser.py <filepath>")
        sys.exit(1)
    analyse(sys.argv[1])
