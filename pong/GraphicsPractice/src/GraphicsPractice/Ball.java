package GraphicsPractice;

public class Ball {
	public int width, height, counter;
	
	public double xPos, yPos;
	
	private double speed, direction;
	
	public Ball(int x, int y, int w, int h) {
		xPos = x;
		yPos = y;
		width = w;
		height = h;
		speed = 3;
		direction = 20 + 50 * Math.random() + 90 * ((int) (Math.random() * 4));
	}
	
	public void render(int[] pixels) {
		for(int y = 0; y < height; y++) {
			int yPix = (int) (y + yPos);
			if (yPix < 0 || yPix >= Pong.HEIGHT) {
				continue;
			}
			
			for(int x = 0; x < width; x++) {
				int xPix = (int) (x + xPos);
				if (xPix < 0 || xPix >= Pong.WIDTH) {
					continue;
				}
				
				pixels[xPix + yPix * Pong.WIDTH] = 0xFFFFFF;
			}
		}
	}
	
	public void update(Player player1, Player player2) {
		xPos += speed*Math.cos(Math.toRadians(direction));
		yPos += -speed*Math.sin(Math.toRadians(direction));
		
		speed += .005;
		
		if(xPos < 0 || xPos + width > Pong.WIDTH) {
			direction = 180 - direction;
		}
		
		if (counter == 0) {
			checkCollision(player1);
			checkCollision(player2);
		}
		else {
			counter--;
		}
		
		if(yPos < 0) {
			Pong.GAMEWINNER = 1;
			player1.score++;
		}
		else if(yPos + height > Pong.HEIGHT) {
			Pong.GAMEWINNER = 2;
			player2.score++;
		}
		
	}
	
	public void checkCollision(Player player) {
		if(!(xPos + width < player.xPos || xPos > player.xPos + player.width || yPos + height < player.yPos || yPos > player.yPos + player.height)) {
			direction = 360 - direction;
			counter = 20;
		}
	}

}
