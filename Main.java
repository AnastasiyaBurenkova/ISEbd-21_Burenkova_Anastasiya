import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Frame;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JLabel;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.awt.event.ActionEvent;
import javax.swing.JCheckBox;

public class Main {

	private JFrame frame;
	private JTextField textMaxSpeed;
	private JTextField textCount—apacitys;
	private JTextField textWeight;
	private JTextField textCountPassengers;

	Color color;
	Color colorGruz;
	int maxSpeed;
	int weight;
	int countPassengers;
	int count—apacitys;
	boolean bamper;
	boolean kuzov;
	boolean kolesa;

	private ITransport interTran;
	private Frame btnColor;
	private Frame btnSelectFigtherColor;

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
		color = Color.GRAY;
		colorGruz = Color.BLUE;
		maxSpeed = 2000;
		count—apacitys = 0;
		weight = 30000;
		countPassengers = 5;

		initialize();

	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 682, 434);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		textMaxSpeed = new JTextField();
		textMaxSpeed.setBounds(176, 227, 86, 20);
		frame.getContentPane().add(textMaxSpeed);
		textMaxSpeed.setColumns(10);

		textCount—apacitys = new JTextField();
		textCount—apacitys.setBounds(81, 261, 86, 20);
		frame.getContentPane().add(textCount—apacitys);
		textCount—apacitys.setColumns(10);

		textWeight = new JTextField();
		textWeight.setBounds(353, 227, 86, 20);
		frame.getContentPane().add(textWeight);
		textWeight.setColumns(10);

		textCountPassengers = new JTextField();
		textCountPassengers.setBounds(368, 261, 86, 20);
		frame.getContentPane().add(textCountPassengers);
		textCountPassengers.setColumns(10);

		JPanel panel = new JPanel();
		panel.setBounds(10, 11, 547, 195);
		frame.getContentPane().add(panel);

		JCheckBox checkBamper = new JCheckBox("¡‡ÏÔÂ" + "");
		checkBamper.setBounds(548, 226, 97, 23);
		frame.getContentPane().add(checkBamper);

		JCheckBox checkKuzov = new JCheckBox(" ÛÁÓ‚");
		checkKuzov.setBounds(548, 260, 97, 23);
		frame.getContentPane().add(checkKuzov);

		JCheckBox checkKolesa = new JCheckBox(" ÓÎÂÒ‡");
		checkKolesa.setBounds(548, 292, 97, 23);
		frame.getContentPane().add(checkKolesa);

		JButton btnDrawPlane = new JButton("«‡‰‡Ú¸ Ï‡¯ËÌÛ");
		btnDrawPlane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (checkFields()) {
					interTran = new Car(maxSpeed, count—apacitys, countPassengers, weight, color);

					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					interTran.draw(gr);

				}

			}
		});
		btnDrawPlane.setBounds(148, 319, 138, 37);
		frame.getContentPane().add(btnDrawPlane);

		JButton btnDrawGruzovik = new JButton("«‡‰‡Ú¸ „ÛÁÓ‚ËÍ");
		btnDrawGruzovik.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkFields()) {
					bamper = checkBamper.isSelected();
					kuzov = checkKuzov.isSelected();
					kolesa = checkKolesa.isSelected();
					interTran = new Gruzovik(maxSpeed, count—apacitys, countPassengers, weight, color, bamper, kuzov,
							kolesa, colorGruz);

					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					interTran.draw(gr);
				}

			}
		});
		btnDrawGruzovik.setBounds(494, 322, 162, 37);
		frame.getContentPane().add(btnDrawGruzovik);

		JButton btnColor = new JButton("÷‚ÂÚ");
		btnColor.setForeground(color);
		btnColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				Color initialBackground = btnColor.getForeground();
				Color foreground = JColorChooser.showDialog(null, "JColorChooser Sample", initialBackground);
				if (foreground != null) {
					btnColor.setForeground(foreground);
				}
				color = foreground;
			}
		});
		btnColor.setBounds(10, 292, 115, 23);
		frame.getContentPane().add(btnColor);

		JButton btnMove = new JButton("ƒ‚ËÊÂÌËÂ");
		btnMove.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (interTran != null) {
					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					interTran.move(gr);
				}
			}
		});
		btnMove.setBounds(556, 88, 100, 23);
		frame.getContentPane().add(btnMove);

		JButton btnSelectFigtherColor = new JButton("ƒÓÔÓÎÌËÚÂÎ¸Ì˚È ˆ‚ÂÚ");
		btnSelectFigtherColor.setForeground(colorGruz);
		btnSelectFigtherColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				Color initialBackground = btnSelectFigtherColor.getForeground();
				Color foreground = JColorChooser.showDialog(null, "JColorChooser Sample", initialBackground);
				if (foreground != null) {
					btnSelectFigtherColor.setForeground(foreground);
				}
				colorGruz = foreground;
			}
		});
		btnSelectFigtherColor.setBounds(318, 326, 166, 23);
		frame.getContentPane().add(btnSelectFigtherColor);

		JLabel lblNewLabel = new JLabel("Ã‡ÍÒËÏ‡Î¸Ì‡ˇ ÒÍÓÓÒÚ¸");
		lblNewLabel.setBounds(6, 230, 181, 17);
		frame.getContentPane().add(lblNewLabel);

		JLabel lblNewLabel_1 = new JLabel("√ÛÁ");
		lblNewLabel_1.setBounds(29, 264, 46, 14);
		frame.getContentPane().add(lblNewLabel_1);

		JLabel texteight = new JLabel("¬ÂÒ");
		texteight.setBounds(290, 230, 46, 14);
		frame.getContentPane().add(texteight);

		JLabel lblNewLabel_3 = new JLabel("œ‡ÒÒ‡ÊË˚");
		lblNewLabel_3.setBounds(290, 264, 111, 14);
		frame.getContentPane().add(lblNewLabel_3);

	}

	private boolean checkParse(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException e) {
			return false;
		}

		return true;
	}

	private boolean checkFields() {
		if (checkParse(textMaxSpeed.getText()))
			maxSpeed = Integer.parseInt(textMaxSpeed.getText());
		if (checkParse(textCount—apacitys.getText()))
			count—apacitys = Integer.parseInt(textCount—apacitys.getText());
		if (checkParse(textWeight.getText()))
			weight = Integer.parseInt(textWeight.getText());
		if (checkParse(textCountPassengers.getText()))
			countPassengers = Integer.parseInt(textCountPassengers.getText());

		System.out.println(maxSpeed + " " + count—apacitys + " " + weight + " " + countPassengers);

		return true;
	}
}
