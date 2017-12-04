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
import java.util.Vector;
import java.awt.event.ActionEvent;
import javax.swing.JCheckBox;
import javax.swing.JList;
import java.awt.Font;

public class Main {

	private JFrame frame;
	Parking parking;

	private Frame btnColor;
	private Frame btnSelectFigtherColor;
	private JTextField numPlace;
	JPanel panel;
	private String[] elements = new String[6];
	JList listLevels;

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
		parking = new Parking(5);

		initialize();
		for (int i = 0; i < 5; i++) {
			elements[i] = "Уровень " + (i+1);
		}

		listLevels.setSelectedIndex(parking.getCurrentLevel());
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 1218, 559);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

			panel = new Panel(parking);
			panel.setBounds(10, 11, 854, 499);
			frame.getContentPane().add(panel);
		

		JButton btnSetPlane = new JButton("Припарковать авто");
		btnSetPlane.setForeground(Color.RED);
		btnSetPlane.setBackground(Color.PINK);
		btnSetPlane.setFont(new Font("Tahoma", Font.PLAIN, 14));
		btnSetPlane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				Color colorDialog = JColorChooser.showDialog(null, "JColorChooser Sample", null);
				if (colorDialog != null) {
					ITransport plane = new Car(1000, 100, 30, 30, colorDialog);
					int place = parking.putPlaneInParking(plane);
					panel.repaint();
					JOptionPane.showMessageDialog(null, "Ваше место: " + place);
				}

			}
		});
		btnSetPlane.setBounds(904, 171, 206, 34);
		frame.getContentPane().add(btnSetPlane);

		JButton btnSetFigther = new JButton("Припарковать грузовик");
		btnSetFigther.setForeground(Color.CYAN);
		btnSetFigther.setBackground(Color.YELLOW);
		btnSetFigther.setFont(new Font("Tahoma", Font.PLAIN, 14));
		btnSetFigther.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color colorDialog1 = JColorChooser.showDialog(null, "JColorChooser Sample", null);
				if (colorDialog1 != null) {
					Color colorDialog = JColorChooser.showDialog(null, "JColorChooser Sample", null);
					if (colorDialog != null) {
						ITransport plane = new Gruzovik(1000, 100, 30, 30, colorDialog1, true, true, true,colorDialog);
						int place = parking.putPlaneInParking(plane);
						panel.repaint();
						JOptionPane.showMessageDialog(null, "Ваше место: " + place);
					}
				}

			}
		});
		btnSetFigther.setBounds(904, 219, 206, 34);
		frame.getContentPane().add(btnSetFigther);

		JPanel panelTake = new JPanel();
		panelTake.setBounds(889, 340, 291, 170);
		frame.getContentPane().add(panelTake);

		JButton btnTake = new JButton("Забрать машину");
		btnTake.setForeground(Color.GREEN);
		btnTake.setBackground(Color.ORANGE);
		btnTake.setFont(new Font("Tahoma", Font.PLAIN, 15));
		btnTake.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				if (checkPlace(numPlace.getText())) {
					ITransport plane = parking.getPlaneInParking(Integer.parseInt(numPlace.getText()));
					Graphics gr = panelTake.getGraphics();
					gr.clearRect(0, 0, panelTake.getWidth(), panelTake.getHeight());
					plane.setPosition(60, 5);
					plane.draw(gr);
					panel.repaint();
				}

			}
		});
		btnTake.setBounds(1032, 300, 160, 29);
		frame.getContentPane().add(btnTake);

		JLabel lblNewLabel = new JLabel("Место:");
		lblNewLabel.setFont(new Font("Tahoma", Font.PLAIN, 15));
		lblNewLabel.setBounds(874, 276, 69, 17);
		frame.getContentPane().add(lblNewLabel);

		numPlace = new JTextField();
		numPlace.setBounds(930, 273, 86, 20);
		frame.getContentPane().add(numPlace);
		numPlace.setColumns(10);

		listLevels = new JList(elements);
		listLevels.setForeground(Color.BLUE);
		listLevels.setFont(new Font("Tahoma", Font.PLAIN, 12));
		listLevels.setBackground(Color.LIGHT_GRAY);
		listLevels.setBounds(966, 11, 144, 135);
		frame.getContentPane().add(listLevels);

		JButton btnLevelDown = new JButton("<<");
		btnLevelDown.setBackground(Color.MAGENTA);
		btnLevelDown.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				parking.levelDown();
				listLevels.setSelectedIndex(parking.getCurrentLevel());
				panel.repaint();
			}
		});
		btnLevelDown.setBounds(869, 130, 89, 23);
		frame.getContentPane().add(btnLevelDown);

		JButton btnLevelUp = new JButton(">>");
		btnLevelUp.setBackground(Color.MAGENTA);
		btnLevelUp.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				parking.levelUp();
				listLevels.setSelectedIndex(parking.getCurrentLevel());
				panel.repaint();
			}
		});
		btnLevelUp.setBounds(1113, 130, 89, 23);
		frame.getContentPane().add(btnLevelUp);

	}

	private boolean checkPlace(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException e) {
			return false;
		}

		if (Integer.parseInt(str) > 20)
			return false;
		return true;
	}
}