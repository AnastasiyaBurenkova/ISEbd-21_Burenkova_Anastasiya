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
	SelectPlane select;

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
			elements[i] = "Уровень " + (i + 1);
		}

		listLevels.setSelectedIndex(parking.getCurrentLevel());

	}

	/**
	 * Initialize the contents of the frame.
	 */

	public void getPlane() {
		select = new SelectPlane(frame);
		if (select.res()) {
			ITransport plane = select.getPlane();
			int place = parking.putPlaneInParking(plane);
			panel.repaint();
			System.out.println("Ваше место: " + place);
		}
	}

	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 1218, 559);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		panel = new Panel(parking);
		panel.setBounds(10, 11, 854, 499);
		frame.getContentPane().add(panel);

		JPanel panelTake = new JPanel();
		panelTake.setBounds(874, 340, 318, 170);
		frame.getContentPane().add(panelTake);

		JButton btnTake = new JButton("Забрать машину");
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
		btnTake.setBounds(1039, 298, 153, 31);
		frame.getContentPane().add(btnTake);

		JLabel lblNewLabel = new JLabel("Место ");
		lblNewLabel.setBounds(884, 270, 46, 14);
		frame.getContentPane().add(lblNewLabel);

		numPlace = new JTextField();
		numPlace.setBounds(940, 267, 86, 20);
		frame.getContentPane().add(numPlace);
		numPlace.setColumns(10);

		listLevels = new JList(elements);
		listLevels.setBounds(957, 11, 153, 111);
		frame.getContentPane().add(listLevels);

		JButton btnLevelDown = new JButton("<<");
		btnLevelDown.setBackground(Color.PINK);
		btnLevelDown.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				parking.levelDown();
				listLevels.setSelectedIndex(parking.getCurrentLevel());
				panel.repaint();
			}
		});
		btnLevelDown.setBounds(874, 133, 89, 23);
		frame.getContentPane().add(btnLevelDown);

		JButton btnLevelUp = new JButton(">>");
		btnLevelUp.setBackground(Color.PINK);
		btnLevelUp.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				parking.levelUp();
				listLevels.setSelectedIndex(parking.getCurrentLevel());
				panel.repaint();
			}
		});
		btnLevelUp.setBounds(1103, 133, 89, 23);
		frame.getContentPane().add(btnLevelUp);

		JButton btnGetPlane = new JButton("Припарковать авто");
		btnGetPlane.setForeground(Color.RED);
		btnGetPlane.setBackground(Color.ORANGE);
		btnGetPlane.setFont(new Font("Tahoma", Font.PLAIN, 20));
		btnGetPlane.addActionListener(new ActionListener() {
			@SuppressWarnings("deprecation")
			public void actionPerformed(ActionEvent e) {
				getPlane();
			}
		});
		btnGetPlane.setBounds(874, 181, 318, 51);
		frame.getContentPane().add(btnGetPlane);

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