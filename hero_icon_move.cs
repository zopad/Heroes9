using Godot;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

public partial class hero_icon_move : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// (._(._(._.)_.)_.)
		GD.Print("Hello World!!$$$NAGafasomééé");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	// Called on input
	public override void _Input(InputEvent @event)
	{
		// Mouse in viewport coordinates.
		if (@event is InputEventMouseButton eventMouseButton)
		{
			if (eventMouseButton.ButtonIndex != MouseButton.Left || eventMouseButton.IsReleased()) return;

			GD.Print("Mouse Click/Unclick at: ", eventMouseButton.Position);
			Node2D iconNode = GetNode<Node2D>("HeroIconSprite");
			// GlobalPos és Pos nem ugyanaz (sima Pos relatív)

			iconNode.GlobalPosition = eventMouseButton.GlobalPosition;

			/*new Thread(() =>
			{ 
				MoveHeroTo(iconNode, eventMouseButton.GlobalPosition); 
			}).Start();*/
		}

		// Print the size of the viewport.
		// GD.Print("Viewport Resolution is: ", GetViewport().GetVisibleRect().Size);
	}
}
