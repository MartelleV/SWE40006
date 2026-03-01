// ===== Smooth Scroll Animations =====
document.addEventListener("DOMContentLoaded", function () {
  // Stagger-animate cards with smooth entrance
  function animateCards(container, baseDelay) {
    const cards = container.querySelectorAll(
      ".music-card, .genre-card, .album-card",
    );

    cards.forEach(function (card, index) {
      // Reset to hidden state
      card.style.opacity = "0";
      card.style.transform = "translateY(20px)";
      card.style.transition = "none";

      // Use double requestAnimationFrame for smooth animation
      requestAnimationFrame(function () {
        requestAnimationFrame(function () {
          const delay = (baseDelay || 0) + index * 0.05 + "s";
          card.style.transition =
            "opacity 0.6s cubic-bezier(0.16, 1, 0.3, 1) " +
            delay +
            "," +
            "transform 0.6s cubic-bezier(0.16, 1, 0.3, 1) " +
            delay;
          card.style.opacity = "1";
          card.style.transform = "translateY(0)";
        });
      });
    });
  }

  // Animate active tab on page load
  const activePane = document.querySelector(".tab-pane.show.active");
  if (activePane) {
    animateCards(activePane, 0.1);
  }

  // Re-animate when switching tabs
  const tabs = document.querySelectorAll('[data-bs-toggle="pill"]');
  tabs.forEach(function (tab) {
    tab.addEventListener("shown.bs.tab", function (event) {
      const targetId = event.target.getAttribute("data-bs-target");
      const targetPane = document.querySelector(targetId);
      if (targetPane) {
        animateCards(targetPane, 0);
      }
    });
  });

  // Add active class to current nav link
  const currentPath = window.location.pathname;
  const navLinks = document.querySelectorAll(".navbar .nav-link");

  navLinks.forEach(function (link) {
    const linkPath = new URL(link.href).pathname;
    if (linkPath === currentPath) {
      link.classList.add("active");
    }
  });

  // Smooth scroll for anchor links
  document.querySelectorAll('a[href^="#"]').forEach(function (anchor) {
    anchor.addEventListener("click", function (e) {
      const targetId = this.getAttribute("href");
      if (targetId !== "#" && targetId !== "") {
        const targetElement = document.querySelector(targetId);
        if (targetElement) {
          e.preventDefault();
          targetElement.scrollIntoView({
            behavior: "smooth",
            block: "start",
          });
        }
      }
    });
  });

  // Add intersection observer for scroll animations
  const observerOptions = {
    threshold: 0.1,
    rootMargin: "0px 0px -50px 0px",
  };

  const observer = new IntersectionObserver(function (entries) {
    entries.forEach(function (entry) {
      if (entry.isIntersecting) {
        entry.target.classList.add("is-visible");
      }
    });
  }, observerOptions);

  // Observe elements with fade-in class
  document.querySelectorAll(".fade-in").forEach(function (element) {
    observer.observe(element);
  });

  // Enhanced hover effects for skill badges
  const skillBadges = document.querySelectorAll(".skill-badge");
  skillBadges.forEach(function (badge) {
    badge.addEventListener("mouseenter", function () {
      this.style.transform = "translateY(-3px) scale(1.05)";
    });
    badge.addEventListener("mouseleave", function () {
      this.style.transform = "translateY(0) scale(1)";
    });
  });

  // Add ripple effect to cards (optional enhancement)
  function createRipple(event) {
    const card = event.currentTarget;
    const ripple = document.createElement("span");
    const rect = card.getBoundingClientRect();
    const size = Math.max(rect.width, rect.height);
    const x = event.clientX - rect.left - size / 2;
    const y = event.clientY - rect.top - size / 2;

    ripple.style.width = ripple.style.height = size + "px";
    ripple.style.left = x + "px";
    ripple.style.top = y + "px";
    ripple.classList.add("ripple");

    const existingRipple = card.querySelector(".ripple");
    if (existingRipple) {
      existingRipple.remove();
    }

    card.appendChild(ripple);

    setTimeout(function () {
      ripple.remove();
    }, 600);
  }

  // Apply ripple to interactive cards
  document
    .querySelectorAll(".genre-card, .album-card")
    .forEach(function (card) {
      card.addEventListener("click", createRipple);
    });

  // Parallax effect for hero avatar (subtle)
  const heroAvatar = document.querySelector(".hero-avatar");
  if (heroAvatar) {
    document.addEventListener("mousemove", function (e) {
      const mouseX = e.clientX / window.innerWidth;
      const mouseY = e.clientY / window.innerHeight;
      const moveX = (mouseX - 0.5) * 10;
      const moveY = (mouseY - 0.5) * 10;

      heroAvatar.style.transform = `translate(${moveX}px, ${moveY}px)`;
    });
  }

  // Add loading state for images
  const images = document.querySelectorAll(".artist-image, .album-cover");
  images.forEach(function (img) {
    img.addEventListener("load", function () {
      this.style.opacity = "1";
    });

    // Set initial opacity
    img.style.opacity = "0";
    img.style.transition = "opacity 0.3s ease-in-out";
  });

  // Console easter egg
  console.log(
    "%c👋 Welcome to StudentPortfolio!",
    "font-size: 16px; font-weight: bold; color: #171717;",
  );
  console.log(
    "%cBuilt with ASP.NET Core MVC",
    "font-size: 12px; color: #525252;",
  );
});

// Add CSS for ripple effect
const style = document.createElement("style");
style.textContent = `
    .ripple {
        position: absolute;
        border-radius: 50%;
        background: rgba(0, 0, 0, 0.1);
        transform: scale(0);
        animation: ripple-animation 0.6s ease-out;
        pointer-events: none;
    }

    @keyframes ripple-animation {
        to {
            transform: scale(2);
            opacity: 0;
        }
    }

    .is-visible {
        opacity: 1 !important;
    }
`;
document.head.appendChild(style);
