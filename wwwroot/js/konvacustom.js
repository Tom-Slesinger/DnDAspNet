$(document).ready(function () {
    // Create a stage
    var stage = new Konva.Stage({
        container: 'container',
        width: window.innerWidth,
        height: window.innerHeight
    });

    // Create a layer
    var layer = new Konva.Layer();

    // Create a rectangle shape
    var rect = new Konva.Rect({
        x: 50,
        y: 50,
        width: 100,
        height: 50,
        fill: 'red',
        draggable: true // Allow the rectangle to be draggable
    });

    // Add the rectangle to the layer
    layer.add(rect);

    // Add the layer to the stage
    stage.add(layer);
});