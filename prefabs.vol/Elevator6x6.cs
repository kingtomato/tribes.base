//--- export object begin ---//
instant SimGroup "elevator6x6" {
	instant SimPath "Path1" {
		isLooping = "False";
		isCompressed = "False";
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "3.63118 -0.385498 -3.33332";
			rotation = "0 0 0";
		};
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "3.63118 -0.385498 6.66665";
			rotation = "0 0 0";
		};
	};
	instant Moveable "elevator_6x61" {
		dataBlock = "elevator6x6";
		name = "";
		position = "-7.26236 0.770996 -3.33332";
		rotation = "0 0 0";
		destroyable = "True";
		deleteOnDestroy = "False";
		Status = "up";
		delayTime = "1750.51";
		waypoint = "top";
	};
};
//--- export object end ---//
