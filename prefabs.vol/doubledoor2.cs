//--- export object begin ---//
instant SimGroup "DoubleDoor2" {
	instant SimPath "Path1" {
		isLooping = "False";
		isCompressed = "False";
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "2.5 0 0";
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
			position = "-2.5 0 0";
			rotation = "0 0 0";
		};
	};
	instant Moveable "DoorOneLeft1" {
		dataBlock = "DoorOneLeft";
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
	instant Moveable "DoorOneRight1" {
		dataBlock = "DoorOneRight";
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
