// EventEase-specific JS functionality

console.log("EventEase eventease.js loaded");

// Example: highlight event cards on hover
document.addEventListener("DOMContentLoaded", () => {
    const cards = document.querySelectorAll(".event-card");
    cards.forEach(card => {
        card.addEventListener("mouseenter", () => {
            card.style.boxShadow = "0 4px 8px rgba(0,0,0,0.2)";
        });
        card.addEventListener("mouseleave", () => {
            card.style.boxShadow = "0 2px 4px rgba(0,0,0,0.1)";
        });
    });
});
