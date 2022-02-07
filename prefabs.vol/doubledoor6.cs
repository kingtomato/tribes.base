//--- export object begin ---//
instant SimGroup "DoubleDoor6" {
	instant SimPath "Path1" {
		isLooping = "False";
		isCompressed = "False";
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "3.5 0 0";
			rotation = "0 0 0";
		};
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "0 0 0";
			rotation = "0 0 0";
		};
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "-3.5 0 0";
			rotation = "0 0 0";
		};
	};
	instant Moveable "DoorSixLeft1" {
		dataBlock = "DoorSixLeft";
		name = "";
		position = "0 0 0";
		rotation = "0 0 0";
		destroyable = "True";
		deleteOnDestroy = "False";
		closeTime = "1";
		Status = "close";
		center = "1";
		fadeTime = "0";
	};
	instant Moveable "DoorSixRight1" {
		dataBlock = "DoorSixRight";
		name = "";
		position = "0 0 0";
		rotation = "0 0 0";
		destroyable = "True";
		deleteOnDestroy = "False";
		closeTime = "1";
		Status = "close";
		center = "1";
		fadeTime = "0";
	};
};
//--- export object end ---//
