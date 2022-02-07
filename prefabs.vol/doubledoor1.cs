//--- export object begin ---//
instant SimGroup "DoubleDoor1" {
	instant SimPath "Path1" {
		isLooping = "False";
		isCompressed = "False";
		instant Marker "Marker1" {
			dataBlock = "PathMarker";
			name = "";
			position = "4 0 0";
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
			position = "-4 0 0";
			rotation = "0 0 0";
		};
	};
	instant Moveable "DoorOneTop1" {
		dataBlock = "DoorOneTop";
		name = "";
		position = "0 0 0";
		rotation = "0 0 0";
		destroyable = "True";
		deleteOnDestroy = "False";
		closeTime = "19.8638";
		Status = "close";
		center = "1";
		fadeTime = "0";
	};
	instant Moveable "DoorOneBottom1" {
		dataBlock = "DoorOneBottom";
		name = "";
		position = "0 0 0";
		rotation = "0 0 0";
		destroyable = "True";
		deleteOnDestroy = "False";
		closeTime = "19.7038";
		Status = "close";
		center = "1";
		fadeTime = "0";
	};
};
//--- export object end ---//
