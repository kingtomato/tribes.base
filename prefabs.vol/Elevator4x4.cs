//--- export object begin ---//
instant SimGroup "elevator4x4" {
	instant SimPath "Path1" {
		isLooping = "False";
		isCompressed = "False";
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "0 0 -3.33333";
			rotation = "0 0 0";
		};
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "0 0 6.66666";
			rotation = "0 0 0";
		};
	};
	instant Moveable "elevator_4x41" {
		dataBlock = "elevator4x4";
		name = "";
		position = "0 0 -3.33333";
		rotation = "0 0 0";
		destroyable = "True";
		deleteOnDestroy = "False";
		waypoint = "top";
		delayTime = "300.794";
		Status = "up";
	};
};
//--- export object end ---//
