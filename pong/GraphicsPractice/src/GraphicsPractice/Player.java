package GraphicsPractice;

public class Player {

	public int xPos, yPos, width, height, score;
	
	protected int speed = 5;
	
	public Player(int x, int y, int w, int h) {
		xPos = x;
		yPos = y;
		width = w;
		height = h;
		score = 0;
	}
	
	public void render(int[] pixels) {
		for(int y = 0; y < height; y++) {
			int yPix = y + yPos;
			if (yPix < 0 || yPix >= Pong.HEIGHT) {
				continue;
			}
			
			for(int x = 0; x < width; x++) {
				int xPix = x + xPos;
				if (xPix < 0 || xPix >= Pong.WIDTH) {
					continue;
				}
				
				pixels[xPix + yPix * Pong.WIDTH] = 0xFFFFFF;
			}
		}
	}
	
	public void update(boolean left, boolean right, Ball ball) {
		if(right && xPos + width < Pong.WIDTH) {
			xPos += speed;
		}
		else if (left && xPos > 0) {
			xPos -= speed;
		}
	}
	
}
