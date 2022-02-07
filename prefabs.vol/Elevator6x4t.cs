//--- export object begin ---//
instant SimGroup "elevator6x4t" {
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
	instant Moveable "elevator_6x4thin1" {
		dataBlock = "elevator6x4thin";
		name = "";
		position = "0 0 -3.33333";
		rotation = "0 0 0";
		destroyable = "True";
		deleteOnDestroy = "False";
		waypoint = "top";
		delayTime = "255.962";
		Status = "up";
	};
};
//--- export object end ---//
