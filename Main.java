import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Component;
import java.awt.EventQueue;
import java.awt.Frame;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JLabel;
import javax.swing.JOptionPane;

import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.awt.event.ActionEvent;
import javax.swing.JCheckBox;
import java.awt.Font;

public class Main {

	private JFrame frame;
	Parking parking;

	private Frame btnColor;
	private Frame btnSelectGruzovikColor;
	private JTextField numPlace;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Main window = new Main();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Main() {
		parking = new Parking();
	
		initialize();
	    
	    
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 1191, 559);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		

		JPanel panel = new Panel(parking);
		panel.setBounds(10, 11, 854, 499);
		frame.getContentPane().add(panel);
		
		

		JButton btnSetPlane = new JButton("Припарковать авто");
		btnSetPlane.setFont(new Font("Tahoma", Font.PLAIN, 16));
		btnSetPlane.setBackground(Color.YELLOW);
		btnSetPlane.setForeground(Color.RED);
		btnSetPlane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				Color colorDialog = JColorChooser.showDialog(null, "Выберите основной цвет", null);
				if (colorDialog != null) {
					ITransport plane = new Car(1000, 100, 30, 30, colorDialog);
					int place = parking.putPlaneInParking(plane);
					panel.repaint();
					JOptionPane.showMessageDialog(null, "Ваше место: " + place);
				}

			}
		});
		btnSetPlane.setBounds(874, 11, 291, 39);
		frame.getContentPane().add(btnSetPlane);

		JButton btnSetGruzovik = new JButton("Припарковать грузовик");
		btnSetGruzovik.setFont(new Font("Tahoma", Font.PLAIN, 16));
		btnSetGruzovik.setForeground(Color.GRAY);
		btnSetGruzovik.setBackground(Color.GREEN);
		btnSetGruzovik.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color colorDialog1 = JColorChooser.showDialog(null, "Выберите основной цвет", null);
				if (colorDialog1 != null) {
					Color colorDialog = JColorChooser.showDialog(null, "Выберите дополительный цвет", null);
					if (colorDialog != null) {
						ITransport plane = new  Gruzovik(1000, 100, 30, 30, colorDialog1, true, true,true, colorDialog);
						int place = parking.putPlaneInParking(plane);
						panel.repaint();
						JOptionPane.showMessageDialog(null, "Ваше место: " + place);
					}
				}

				

			}
		});
		btnSetGruzovik.setBounds(874, 61, 291, 39);
		frame.getContentPane().add(btnSetGruzovik);

		JPanel panelTake = new JPanel();
		panelTake.setForeground(Color.BLACK);
		panelTake.setBackground(Color.WHITE);
		panelTake.setBounds(874, 126, 291, 170);
		frame.getContentPane().add(panelTake);

		JButton btnTake = new JButton("Забрать машину");
		btnTake.setForeground(Color.BLUE);
		btnTake.setBackground(Color.LIGHT_GRAY);
		btnTake.setFont(new Font("Tahoma", Font.PLAIN, 16));
		btnTake.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				if(checkPlace(numPlace.getText())) {
					ITransport plane = parking.getPlaneInParking(Integer.parseInt(numPlace.getText()));
					Graphics gr = panelTake.getGraphics();
					gr.clearRect(0, 0, panelTake.getWidth(), panelTake.getHeight());
					plane.setPosition(60, 5);
					plane.draw(gr);
					panel.repaint();
				}
				
			}
		});
		btnTake.setBounds(1002, 382, 163, 62);
		frame.getContentPane().add(btnTake);

		JLabel lblNewLabel = new JLabel("Место:");
		lblNewLabel.setFont(new Font("Tahoma", Font.PLAIN, 16));
		lblNewLabel.setForeground(Color.MAGENTA);
		lblNewLabel.setBounds(899, 336, 57, 33);
		frame.getContentPane().add(lblNewLabel);

		numPlace = new JTextField();
		numPlace.setFont(new Font("Tahoma", Font.PLAIN, 15));
		numPlace.setBounds(966, 336, 86, 28);
		frame.getContentPane().add(numPlace);
		numPlace.setColumns(10);
		
	}
	
	private boolean checkPlace(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException e) {
			return false;
		}

		if(Integer.parseInt(str)>20) return false;
		return true;
	}

	
}