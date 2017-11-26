using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication18
{
    public interface ITransport
    {
        void moveCar(Graphics g);

        void drawCar(Graphics g);

        void setPosition(int x, int y);

        void loadPassenger(int count);

        void loadСapacity(int count);
        int getPassenger();
        int getСapacity();
        void setMainColor(Color color);
        string getInfo();
    }
}
