extends Node3D


# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	OS.w = ("Game v0.1 | fps: " + str(Engine.get_frames_per_second()))

