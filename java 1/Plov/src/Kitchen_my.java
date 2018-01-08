import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JSpinner;
import javax.swing.SpinnerNumberModel;
import javax.swing.JButton;
import javax.swing.JRadioButton;
import javax.swing.ButtonGroup;
import javax.swing.JCheckBox;



import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.Color;
import java.awt.SystemColor;


public class Kitchen_my {

	private JFrame frame;
	private final ButtonGroup buttonGroup = new ButtonGroup();
	
	
	private Onion[] onion;
	private Potato[] potato;
	private Carrot[] carrot;
	private Kabach[] kabach;
	private Water[] water;
	private Salt salt;
	private Oil oil;
	
	private Knife knife;
	private Stove stove;
	private WaterTap watertap;
	private Pan pan;
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Kitchen_my window = new Kitchen_my();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	public Kitchen_my() {
		initialize();
	}
	
	/**
	 * Create the application.
	 */
	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		
		knife = new Knife () ;
		stove = new Stove () ;
		pan = new Pan () ;
		watertap = new WaterTap() ; 
		salt = new Salt();
		oil = new Oil () ; 
		
		frame = new JFrame();
		frame.setBounds(100, 100, 850, 450);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JLabel Stove = new JLabel("�����");
		Stove.setBounds(10, 11, 46, 14);
		frame.getContentPane().add(Stove);
		
		JLabel Knife = new JLabel("���");
		Knife.setForeground(Color.MAGENTA);
		Knife.setBounds(343, 11, 46, 14);
		frame.getContentPane().add(Knife);
		
		JLabel WaterTap = new JLabel("����");
		WaterTap.setBounds(461, 158, 46, 14);
		frame.getContentPane().add(WaterTap);
		
		JLabel label_4 = new JLabel("������ ������ ���-�� ���� ������������");
		label_4.setBounds(5, 158, 246, 14);
		frame.getContentPane().add(label_4);
		
		JLabel Potato = new JLabel("���������");
		Potato.setForeground(Color.RED);
		Potato.setBounds(25, 186, 146, 14);
		frame.getContentPane().add(Potato);
		
		JLabel Kabach = new JLabel("�������");
		Kabach.setBounds(214, 186, 129, 14);
		frame.getContentPane().add(Kabach);
		
		JLabel label = new JLabel("���� ���.");
		label.setForeground(SystemColor.textHighlight);
		label.setBounds(214, 211, 69, 14);
		frame.getContentPane().add(label);
		
		JLabel Carrot = new JLabel("�������");
		Carrot.setForeground(Color.BLACK);
		Carrot.setBackground(Color.LIGHT_GRAY);
		Carrot.setBounds(25, 240, 146, 14);
		frame.getContentPane().add(Carrot);
		
		JLabel Onion = new JLabel("���");
		Onion.setForeground(Color.BLACK);
		Onion.setBounds(214, 240, 29, 14);
		frame.getContentPane().add(Onion);
		
		JSpinner count_potato = new JSpinner();
		count_potato.setModel(new SpinnerNumberModel(new Integer(0), new Integer(0), null, new Integer(1)));
		count_potato.setBounds(155, 183, 29, 20);
		frame.getContentPane().add(count_potato);
		
		JSpinner count_kabach = new JSpinner();
		count_kabach.setModel(new SpinnerNumberModel(new Integer(0), new Integer(0), null, new Integer(1)));
		count_kabach.setBounds(293, 180, 29, 20);
		frame.getContentPane().add(count_kabach);
		
		JSpinner count_carrot = new JSpinner();
		count_carrot.setModel(new SpinnerNumberModel(new Integer(0), new Integer(0), null, new Integer(1)));
		count_carrot.setBounds(155, 237, 29, 20);
		frame.getContentPane().add(count_carrot);
		
		JSpinner count_onion = new JSpinner();
		count_onion.setModel(new SpinnerNumberModel(new Integer(0), new Integer(0), null, new Integer(1)));
		count_onion.setBounds(293, 237, 29, 20);
		frame.getContentPane().add(count_onion);
		
		JSpinner count_water = new JSpinner();
		count_water.setBounds(293, 206, 29, 20);
		frame.getContentPane().add(count_water);
		
			
		JButton Add = new JButton("������ �����������");
		Add.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				
				onion = new Onion[Integer.parseInt((count_onion.getValue()).toString())];

	            for (int i = 0; i < onion.length; ++i)
	            {
	                onion[i] = new Onion();
	                count_onion.setEnabled(false);
	            }
	           
	           
	            potato = new Potato[Integer.parseInt((count_potato.getValue()).toString())];
	            for (int i = 0; i < potato.length; ++i)
	            {
	                potato[i] = new Potato();
	                count_potato.setEnabled(false);
	            }
	            
	            
	            carrot = new Carrot[Integer.parseInt((count_carrot.getValue()).toString())];
	            for (int i = 0; i < carrot.length; ++i)
	            {
	            	carrot[i] = new Carrot();
	            	count_carrot.setEnabled(false);
	            }
	            
	           
	            kabach = new Kabach[Integer.parseInt((count_kabach.getValue()).toString())];
	            for (int i = 0; i < kabach.length; ++i)
	            {
	            	kabach[i] = new Kabach();
	            	 count_kabach.setEnabled(false);
	            }
	            
	            water = new Water[Integer.parseInt((count_water.getValue()).toString())];
	            for (int i = 0; i < water.length; ++i)
	            {
	            	water[i] = new Water();
	            	count_water.setEnabled(false);
	            }
	            
	            
	            
			}
		});
		Add.setBounds(20, 265, 204, 43);
		frame.getContentPane().add(Add);
		

		JCheckBox AddSalt = new JCheckBox("����");
		AddSalt.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			
				salt = new Salt();
                pan.AddSalt(salt);
				salt.SetCount(true);
				
			}
		});
		AddSalt.setBounds(20, 210, 58, 23);
		frame.getContentPane().add(AddSalt);
		
		
		JCheckBox AddOil = new JCheckBox("�����");
		AddOil.setForeground(new Color(0, 0, 0));
		AddOil.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			
				 oil = new Oil();
	                pan.AddOil(oil);
				oil.SetCount(true);
				JOptionPane.showMessageDialog(frame,"�������� �����");
				
			}
		});
		AddOil.setBounds(20, 32, 71, 23);
		frame.getContentPane().add(AddOil);
		
	
		JRadioButton WaterTap_on = new JRadioButton("���");
		buttonGroup.add(WaterTap_on);
		WaterTap_on.setBounds(519, 185, 73, 23);
		frame.getContentPane().add(WaterTap_on);
		WaterTap_on.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e){
				watertap.SetOpen(true);
			} });
		
		JRadioButton WaterTap_off = new JRadioButton("����");
		buttonGroup.add(WaterTap_off);
		WaterTap_off.setBounds(461, 185, 56, 23);
		frame.getContentPane().add(WaterTap_off);
		WaterTap_off.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e){
				watertap.SetOpen(false);
			} });
		
		JButton Wash_kabach = new JButton("���� �������");
		Wash_kabach.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (watertap.GetOpen()==true) { 
						if (kabach==null ) {
							JOptionPane.showMessageDialog(frame,"������� ��� ");
							return; 
						}
						if (kabach.length==0 ) {
							JOptionPane.showMessageDialog(frame,"������� ��� ");
							return; 
						}
					
			            for (int i = 0; i < kabach.length; ++i)
			            {
			            	kabach[i].SetDirty( false);
			            }
			            JOptionPane.showMessageDialog(frame,"������� ������");
			            WaterTap_off.setSelected(true);
				}
				else if  (watertap.GetOpen()==false) {
					  JOptionPane.showMessageDialog(frame,"������ ����");
				} 
				
			}
		});
		Wash_kabach.setBounds(461, 210, 170, 23);
		frame.getContentPane().add(Wash_kabach);
		
		JButton button_2 = new JButton("���� ���������");
		button_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (watertap.GetOpen()==true) {
						if (potato==null ) {
							JOptionPane.showMessageDialog(frame,"��������� ��� ");
							return; 
						}
						if (potato.length==0 ) {
							JOptionPane.showMessageDialog(frame,"��������� ��� ");
							return; 
						}
					
			            for (int i = 0; i < potato.length; ++i)
			            {
			            	potato[i].SetDirty( false);
			            }
			            JOptionPane.showMessageDialog(frame,"��������� ������");
			            WaterTap_off.setSelected(true);
				}
				else if  (watertap.GetOpen()==false) {
					  JOptionPane.showMessageDialog(frame,"������ ����");
				} 
			}
		});
		button_2.setBounds(461, 235, 170, 23);
		frame.getContentPane().add(button_2);
		
		JButton button_3 = new JButton("���� �������");
		button_3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (watertap.GetOpen()) { 
						if (carrot==null ) {
							JOptionPane.showMessageDialog(frame,"������� ��� ");
							return; 
						}
						if (carrot.length==0 ) {
							JOptionPane.showMessageDialog(frame,"������� ��� ");
							return; 
						}
					
			            for (int i = 0; i < carrot.length; ++i)
			            {
			            	carrot[i].SetDirty( false);
			            }
			            JOptionPane.showMessageDialog(frame,"������� ������");
			             WaterTap_off.setSelected(true);
				}
				else if  (watertap.GetOpen()==false) {
					  JOptionPane.showMessageDialog(frame,"������ ����");
				} 
			}
		});
		button_3.setBounds(461, 260, 170, 23);
		frame.getContentPane().add(button_3);
		
		JButton button = new JButton("���� ���");
		button.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (watertap.GetOpen()) { 
						if (onion==null ) {
							JOptionPane.showMessageDialog(frame,"���� ��� ");
							return; 
						}
						if (onion.length==0 ) {
							JOptionPane.showMessageDialog(frame,"���� ��� ");
							return; 
						}
					
			            for (int i = 0; i < onion.length; ++i)
			            {
			            	if (onion[i].GetDirty()==true) { 
			            		onion[i].SetDirty( false);
			            	}
			            	
			            }
			            JOptionPane.showMessageDialog(frame,"��� ������");
			             WaterTap_off.setSelected(true);
				}
				else if  (watertap.GetOpen()==false) {
					  JOptionPane.showMessageDialog(frame,"������ ����");
				} 
			}
		});
		button.setBounds(461, 285, 170, 23);
		frame.getContentPane().add(button);
		
		JButton cut_potato = new JButton("������ � ������� ���������");
		cut_potato.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (potato == null)
	            {
					JOptionPane.showMessageDialog(frame, "��������� ��� ");
	      
	                return;
	            }
				
				if (potato.length == 0)
	            {
					JOptionPane.showMessageDialog(frame, "��������� ���");
	     
	                return;
	            } 
			
				for (int i = 0; i < potato.length; ++i) {
					if (potato[i].GetDirty()) {
						JOptionPane.showMessageDialog(frame,"��������� ������� ");  return;
					} 
				
				}
	            
				
				 for (int i = 0; i < potato.length; ++i)
		            {
					 if (potato[i].GetDirty()==false) {
						 knife.Cut_potato(potato[i]);
						
						}  
		               
		            }
				 JOptionPane.showMessageDialog(frame,"��������� ��������� � �������� "); 
	            
			
				
			}
		});
		cut_potato.setBounds(273, 22, 244, 23);
		frame.getContentPane().add(cut_potato);
		
		JButton cut_kabach = new JButton("������ �������");
		cut_kabach.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (kabach == null)
	            {
					JOptionPane.showMessageDialog(frame, "������� ��� ");
	      
	                return;
	            }
				
				if (kabach.length == 0)
	            {
					JOptionPane.showMessageDialog(frame, "������� ���");
	     
	                return;
	            } 
			
				for (int i = 0; i < kabach.length; ++i) {
					if (kabach[i].GetDirty()) {
						JOptionPane.showMessageDialog(frame,"������� ������� ");  return;
					} 
				
				}
	            
				
				 for (int i = 0; i < kabach.length; ++i)
		            {
					 if (kabach[i].GetDirty()==false) {
						 knife.Cut_kabach(kabach[i]);
						
						}  
		               
		            }
				 JOptionPane.showMessageDialog(frame,"������� �������� "); 
	            
			
				
			}
		});
		cut_kabach.setBounds(273, 120, 244, 23);
		frame.getContentPane().add(cut_kabach);
		
		JButton cut_onion = new JButton("������ ���");
		cut_onion.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (onion == null)
	            {
					JOptionPane.showMessageDialog(frame, "���� ��� ");
	     
	                return;
	            }
				
				if (onion.length == 0)
	            {
					JOptionPane.showMessageDialog(frame, "���� ���");
	     
	                return;
	            }
			
				for (int i = 0; i < onion.length; ++i) {
					if (onion[i].GetDirty()) {
						JOptionPane.showMessageDialog(frame,"��� ������� ");  return;
					} 
				
				}
	            
				
				 for (int i = 0; i < onion.length; ++i)
		            {
					 if (onion[i].GetDirty()==false) {
						 knife.Cut_onion(onion[i]);
						
						}  
		               
		            }
				 JOptionPane.showMessageDialog(frame,"��� �������� "); 
				
		
			}
		});
		cut_onion.setBounds(273, 56, 244, 23);
		frame.getContentPane().add(cut_onion);
		
		
		JButton cut_carrot = new JButton("������ �������");
		cut_carrot.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (carrot == null)
	            {
					JOptionPane.showMessageDialog(frame, "������� ���������� ");
	     
	                return;
	            }
				
				if (carrot.length == 0)
	            {
					JOptionPane.showMessageDialog(frame, "������� ����������");
	     
	                return;
	            }
				for (int i = 0; i < carrot.length; ++i) {
					if (carrot[i].GetDirty()) {
						JOptionPane.showMessageDialog(frame,"������� ������� ");  return;
					} 
				
				}
	            
				
				 for (int i = 0; i < carrot.length; ++i)
		            {
					 if (carrot[i].GetDirty()==false) {
						 knife.Cut_carrot(carrot[i]);
						
						}  
		               
		            }
				 JOptionPane.showMessageDialog(frame,"������� �������� ");
				
		
			}
		});
		cut_carrot.setBounds(273, 90, 244, 23);
		frame.getContentPane().add(cut_carrot);
		
		JButton AddOnion = new JButton("�������� ���");
		AddOnion.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if  (onion==null) {	
					JOptionPane.showMessageDialog(frame, "��� ���������� ");
                return;
                }
				if  (onion.length==0) {	
					JOptionPane.showMessageDialog(frame, "��� ���������� ");
                return;
                }
				for (int i = 0; i < onion.length; ++i) {
					if (onion[i].GetDirty()) {
						JOptionPane.showMessageDialog(frame,"��� ������� ");  return;
					} 
				
				}
				for (int i = 0; i < onion.length; ++i) {
					if (onion[i].getCut_ready()==false) {
						JOptionPane.showMessageDialog(frame,"��� ��� �� ��������");  return;
					} 
				
				}
				
				 pan.Init_Onion(onion.length);
				 
			    for (int i = 0; i < onion.length; ++i)
	            {
	                pan.AddOnion(onion[i]);
	                onion[i].SetAdd(true);
	               
	            }
			    JOptionPane.showMessageDialog(frame,"��� ��������");
			}
		});
		AddOnion.setBounds(564, 5, 195, 23);
		frame.getContentPane().add(AddOnion);
		
		JButton Addpotato = new JButton("�������� ���������");
		Addpotato.setForeground(Color.RED);
		Addpotato.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if  (potato==null) {	
					JOptionPane.showMessageDialog(frame, "��������� ���������� ");
                return;
                }
				if  (potato.length==0) {	
					JOptionPane.showMessageDialog(frame, "��������� ���������� ");
                return;
                }
				for (int i = 0; i < potato.length; ++i) {
					if (potato[i].GetDirty()) {
						JOptionPane.showMessageDialog(frame,"��������� ������� ");  return;
					} 
				
				}
				for (int i = 0; i < potato.length; ++i) {
					if (potato[i].getCut_ready()==false) {
						JOptionPane.showMessageDialog(frame,"��������� ��� �� ��������");  return;
					} 
				
				}
				 pan.Init_Potato(onion.length);
			  
				 for (int i = 0; i < potato.length; ++i)
	            {
	                pan.Addpotato(potato[i]);
	                potato[i].SetAdd(true);
	               
	            }
			    JOptionPane.showMessageDialog(frame,"��������� ��������");
			}
		});
		Addpotato.setBounds(564, 30, 195, 23);
		frame.getContentPane().add(Addpotato);
		
		JButton AddCarrot = new JButton("�������� �������");
		AddCarrot.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if  (carrot==null) {	
					JOptionPane.showMessageDialog(frame, "������� ���������� ");
                return;
                }
				if  (carrot.length==0) {	
					JOptionPane.showMessageDialog(frame, "������� ���������� ");
                return;
                }
				for (int i = 0; i < carrot.length; ++i) {
					if (carrot[i].GetDirty()) {
						JOptionPane.showMessageDialog(frame,"������� ������� ");  return;
					} 
				
				}
				for (int i = 0; i < carrot.length; ++i) {
					if (carrot[i].getCut_ready()==false) {
						JOptionPane.showMessageDialog(frame,"������� ��� �� ��������");  return;
					} 
				
				}
				 pan.Init_Carrot(carrot.length);
				 
			    for (int i = 0; i < carrot.length; ++i)
	            {
	                pan.AddCarrot(carrot[i]);
	                carrot[i].SetAdd(true);
	            }
			    JOptionPane.showMessageDialog(frame,"������� ���������");
			}
		});
		AddCarrot.setBounds(564, 55, 195, 23);
		frame.getContentPane().add(AddCarrot);
		
		JButton Addkabach = new JButton("�������� �������");
		//Addkabach.setEnabled(false);
		Addkabach.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if  (kabach==null) {	
					JOptionPane.showMessageDialog(frame, "������� ���������� ");
                return;
                }
				if  (kabach.length==0) {	
					JOptionPane.showMessageDialog(frame, "������� ���������� ");
                return;
                }
				for (int i = 0; i < kabach.length; ++i) {
					if (kabach[i].GetDirty()) {
						JOptionPane.showMessageDialog(frame,"������� ������� ");  return;
					} 
				}
				 pan.Init_Kabach(kabach.length);
				 
				 
			    for (int i = 0; i < kabach.length; ++i)
	            {
			    	kabach[i].SetAdd(true);
	                pan.Addkabach(kabach[i]);
	            }
			    JOptionPane.showMessageDialog(frame,"������� ��������");
			}
		});
		Addkabach.setBounds(564, 80, 195, 23);
		frame.getContentPane().add(Addkabach);
		
		JButton AddWater = new JButton("�������� ����");
		AddWater.setForeground(SystemColor.textHighlight);
		AddWater.setEnabled(false);
		AddWater.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (watertap.GetOpen()) {
					
				
					 pan.Init_Water(water.length);
					 
					 
					 for (int i = 0; i < water.length; ++i)
			            {
			                pan.AddWater(water[i]);
			                water[i].SetAdd(true);
			            }
					 JOptionPane.showMessageDialog(frame,"���� ��������");
				}
				else if  (!watertap.GetOpen()) {
					  JOptionPane.showMessageDialog(frame,"������ ����");
				} 
			}
		});
		AddWater.setBounds(564, 105, 195, 23);
		frame.getContentPane().add(AddWater);
		
		
		JCheckBox StoveOn = new JCheckBox("���");
		StoveOn.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				stove.SetState(true);
			}
		});
		StoveOn.setBounds(48, 7, 56, 23);
		frame.getContentPane().add(StoveOn); 
		
		
		JButton cook2 = new JButton("������");
		cook2.setEnabled(false);
		cook2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (pan.Check2()==false) {
					JOptionPane.showMessageDialog(frame,"�� ��������� �� ��������� ");
	   	      	return;
	   	      	} else 	{
	   	      	stove.Cooking();
	   	      		JOptionPane.showMessageDialog(frame,"�� ��, ��������! ������!"); 
	   	      	}
			}
		});
		cook2.setBounds(10, 130, 133, 23);
		frame.getContentPane().add(cook2);
		
		
		JButton button_1 = new JButton("��������� �� ����� ����������");
		button_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
					if (stove.GetState()==false) {
						JOptionPane.showMessageDialog(frame,"���� �������� �����");
						return;
					}
					else { 
						stove.SetPan(pan);
						JOptionPane.showMessageDialog(frame,"����� ��������,���������� �� ���");
					}
			}
		});
		button_1.setBounds(10, 80, 233, 23);
		frame.getContentPane().add(button_1);
		

		JButton cook1 = new JButton("������");
		cook1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if  (stove.GetPan()==null) {
					JOptionPane.showMessageDialog(frame,"�� ����� �����");
				return; 
				}
				if (!pan.Check()) { 
					JOptionPane.showMessageDialog(frame,"�� ��� ����������� ��������� �� ��������� ");
					
	   	      	return; 
				}
				else {
					
					AddWater.setEnabled(true); 
					cook2.setEnabled(true); 
					stove.Cooking(); 
				JOptionPane.showMessageDialog(frame,"�������!"); 
				}
			}
		});
		cook1.setBounds(10, 105, 133, 23);
		frame.getContentPane().add(cook1);
	}

}
