const moveable = new Moveable(document.body, {
    target: document.getElementById("moveItem"), // Use getElementById instead of querySelector for ID selection
    draggable: true,
});

moveable.on("drag", ({ target, transform }) => {
    target.style.transform = transform;
});