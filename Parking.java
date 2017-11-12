import java.awt.Color;
import java.awt.Graphics;

public class Parking {
	ClassArray<ITransport> parking;

	int countPlaces = 20;
	int placeWidth = 210;
	int placeHeight = 80;

	public Parking()
	{
		parking = new ClassArray<ITransport>(countPlaces, null);
	}

	public int putPlaneInParking(ITransport plane)
	{
		return parking.plus(parking, plane);
	}

	public ITransport getPlaneInParking(int index)
	{
		return parking.minus(parking, index);
	}

	public void draw(Graphics g,int width,int height)
	{
		drawMarking(g);
		for(int i = 0; i < countPlaces; i++)
		{
			ITransport plane = parking.getObject(i);
			if (plane != null)
			{
				plane.setPosition(5 + i / 5 * placeWidth + 55, i % 5 * placeHeight + 15);
				plane.draw(g);
			}
		}
		
	}

	public void drawMarking(Graphics g)
	{
		g.setColor(Color.BLACK);
		g.drawRect( 0, 0, (countPlaces / 5) * placeWidth, 450);
		for(int i = 0; i < countPlaces / 5; i++)
		{
			for(int j = 0; j < 6; j++)
			{
				g.drawLine( i * placeWidth,j* placeHeight,i*placeWidth+110,j*placeHeight);
			}
			g.drawLine( i * placeWidth, 0, i * placeWidth,400);
		}
		
	}


}