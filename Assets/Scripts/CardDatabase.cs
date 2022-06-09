using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> CardList = new List<Card>();

    void Awake()
    {
        CardList.Add(new Card(0, "Fire", "Red", "1", 1));
        CardList.Add(new Card(1, "Fire", "Red", "2", 2));
        CardList.Add(new Card(2, "Fire", "Red", "3", 3));
        CardList.Add(new Card(3, "Fire", "Red", "4", 4));
        CardList.Add(new Card(4, "Fire", "Red", "5", 5));
        CardList.Add(new Card(5, "Fire", "Red", "6", 6));
        CardList.Add(new Card(6, "Fire", "Red", "7", 7));
        CardList.Add(new Card(7, "Fire", "Red", "8", 8));
        CardList.Add(new Card(8, "Fire", "Red", "9", 9));
        CardList.Add(new Card(9, "Fire", "Red", "10", 10));
        CardList.Add(new Card(10, "Fire", "Red", "F", 0));
        CardList.Add(new Card(11, "Fire", "Red", "W", 0));
        CardList.Add(new Card(12, "Fire", "Red", "E", 0));
        CardList.Add(new Card(13, "Fire", "Red", "T", 0));
        CardList.Add(new Card(14, "Fire", "Red", "B", 0));
        CardList.Add(new Card(15, "Fire", "Blue", "1", 1));
        CardList.Add(new Card(16, "Fire", "Blue", "2", 2));
        CardList.Add(new Card(17, "Fire", "Blue", "3", 3));
        CardList.Add(new Card(18, "Fire", "Blue", "4", 4));
        CardList.Add(new Card(19, "Fire", "Blue", "5", 5));
        CardList.Add(new Card(20, "Fire", "Blue", "6", 6));
        CardList.Add(new Card(21, "Fire", "Blue", "7", 7));
        CardList.Add(new Card(22, "Fire", "Blue", "8", 8));
        CardList.Add(new Card(23, "Fire", "Blue", "9", 9));
        CardList.Add(new Card(24, "Fire", "Blue", "10", 10));
        CardList.Add(new Card(25, "Fire", "Blue", "F", 0));
        CardList.Add(new Card(26, "Fire", "Blue", "W", 0));
        CardList.Add(new Card(27, "Fire", "Blue", "E", 0));
        CardList.Add(new Card(28, "Fire", "Blue", "T", 0));
        CardList.Add(new Card(28, "Fire", "Blue", "B", 0));
        CardList.Add(new Card(29, "Fire", "Brown", "1", 1));
        CardList.Add(new Card(30, "Fire", "Brown", "2", 2));
        CardList.Add(new Card(31, "Fire", "Brown", "3", 3));
        CardList.Add(new Card(32, "Fire", "Brown", "4", 4));
        CardList.Add(new Card(33, "Fire", "Brown", "5", 5));
        CardList.Add(new Card(34, "Fire", "Brown", "6", 6));
        CardList.Add(new Card(35, "Fire", "Brown", "7", 7));
        CardList.Add(new Card(36, "Fire", "Brown", "8", 8));
        CardList.Add(new Card(37, "Fire", "Brown", "9", 9));
        CardList.Add(new Card(38, "Fire", "Brown", "10", 10));
        CardList.Add(new Card(39, "Fire", "Brown", "F", 0));
        CardList.Add(new Card(40, "Fire", "Brown", "W", 0));
        CardList.Add(new Card(41, "Fire", "Brown", "E", 0));
        CardList.Add(new Card(42, "Fire", "Brown", "T", 0));
        CardList.Add(new Card(43, "Fire", "Brown", "B", 0));
        CardList.Add(new Card(44, "Fire", "Yellow", "1", 1));
        CardList.Add(new Card(45, "Fire", "Yellow", "2", 2));
        CardList.Add(new Card(46, "Fire", "Yellow", "3", 3));
        CardList.Add(new Card(47, "Fire", "Yellow", "4", 4));
        CardList.Add(new Card(48, "Fire", "Yellow", "5", 5));
        CardList.Add(new Card(49, "Fire", "Yellow", "6", 6));
        CardList.Add(new Card(50, "Fire", "Yellow", "7", 7));
        CardList.Add(new Card(51, "Fire", "Yellow", "8", 8));
        CardList.Add(new Card(52, "Fire", "Yellow", "9", 9));
        CardList.Add(new Card(53, "Fire", "Yellow", "10", 10));
        CardList.Add(new Card(54, "Fire", "Yellow", "F", 0));
        CardList.Add(new Card(55, "Fire", "Yellow", "W", 0));
        CardList.Add(new Card(56, "Fire", "Yellow", "E", 0));
        CardList.Add(new Card(57, "Fire", "Yellow", "T", 0));
        CardList.Add(new Card(58, "Fire", "Yellow", "B", 0));
        CardList.Add(new Card(59, "Fire", "Black", "1", 1));
        CardList.Add(new Card(60, "Fire", "Black", "2", 2));
        CardList.Add(new Card(61, "Fire", "Black", "3", 3));
        CardList.Add(new Card(62, "Fire", "Black", "4", 4));
        CardList.Add(new Card(63, "Fire", "Black", "5", 5));
        CardList.Add(new Card(64, "Fire", "Black", "6", 6));
        CardList.Add(new Card(65, "Fire", "Black", "7", 7));
        CardList.Add(new Card(66, "Fire", "Black", "8", 8));
        CardList.Add(new Card(67, "Fire", "Black", "9", 9));
        CardList.Add(new Card(68, "Fire", "Black", "10", 10));
        CardList.Add(new Card(70, "Fire", "Black", "F", 0));
        CardList.Add(new Card(71, "Fire", "Black", "W", 0));
        CardList.Add(new Card(72, "Fire", "Black", "E", 0));
        CardList.Add(new Card(73, "Fire", "Black", "T", 0));
        CardList.Add(new Card(74, "Fire", "Black", "B", 0));
        CardList.Add(new Card(75, "Water", "Red", "1", 1));
        CardList.Add(new Card(76, "Water", "Red", "2", 2));
        CardList.Add(new Card(77, "Water", "Red", "3", 3));
        CardList.Add(new Card(78, "Water", "Red", "4", 4));
        CardList.Add(new Card(79, "Water", "Red", "5", 5));
        CardList.Add(new Card(80, "Water", "Red", "6", 6));
        CardList.Add(new Card(81, "Water", "Red", "7", 7));
        CardList.Add(new Card(82, "Water", "Red", "8", 8));
        CardList.Add(new Card(83, "Water", "Red", "9", 9));
        CardList.Add(new Card(84, "Water", "Red", "10", 10));
        CardList.Add(new Card(85, "Water", "Red", "F", 0));
        CardList.Add(new Card(86, "Water", "Red", "W", 0));
        CardList.Add(new Card(87, "Water", "Red", "E", 0));
        CardList.Add(new Card(88, "Water", "Red", "T", 0));
        CardList.Add(new Card(89, "Water", "Red", "B", 0));
        CardList.Add(new Card(90, "Water", "Blue", "1", 1));
        CardList.Add(new Card(91, "Water", "Blue", "2", 2));
        CardList.Add(new Card(92, "Water", "Blue", "3", 3));
        CardList.Add(new Card(93, "Water", "Blue", "4", 4));
        CardList.Add(new Card(94, "Water", "Blue", "5", 5));
        CardList.Add(new Card(95, "Water", "Blue", "6", 6));
        CardList.Add(new Card(96, "Water", "Blue", "7", 7));
        CardList.Add(new Card(97, "Water", "Blue", "8", 8));
        CardList.Add(new Card(98, "Water", "Blue", "9", 9));
        CardList.Add(new Card(99, "Water", "Blue", "10", 10));
        CardList.Add(new Card(100, "Water", "Blue", "F", 0));
        CardList.Add(new Card(101, "Water", "Blue", "W", 0));
        CardList.Add(new Card(102, "Water", "Blue", "E", 0));
        CardList.Add(new Card(103, "Water", "Blue", "T", 0));
        CardList.Add(new Card(104, "Water", "Blue", "B", 0));
        CardList.Add(new Card(105, "Water", "Brown", "1", 1));
        CardList.Add(new Card(106, "Water", "Brown", "2", 2));
        CardList.Add(new Card(107, "Water", "Brown", "3", 3));
        CardList.Add(new Card(108, "Water", "Brown", "4", 4));
        CardList.Add(new Card(109, "Water", "Brown", "5", 5));
        CardList.Add(new Card(110, "Water", "Brown", "6", 6));
        CardList.Add(new Card(111, "Water", "Brown", "7", 7));
        CardList.Add(new Card(112, "Water", "Brown", "8", 8));
        CardList.Add(new Card(113, "Water", "Brown", "9", 9));
        CardList.Add(new Card(114, "Water", "Brown", "10", 10));
        CardList.Add(new Card(115, "Water", "Brown", "F", 0));
        CardList.Add(new Card(116, "Water", "Brown", "W", 0));
        CardList.Add(new Card(117, "Water", "Brown", "E", 0));
        CardList.Add(new Card(118, "Water", "Brown", "T", 0));
        CardList.Add(new Card(119, "Water", "Brown", "B", 0));
        CardList.Add(new Card(120, "Water", "Yellow", "1", 1));
        CardList.Add(new Card(121, "Water", "Yellow", "2", 2));
        CardList.Add(new Card(122, "Water", "Yellow", "3", 3));
        CardList.Add(new Card(123, "Water", "Yellow", "4", 4));
        CardList.Add(new Card(124, "Water", "Yellow", "5", 5));
        CardList.Add(new Card(125, "Water", "Yellow", "6", 6));
        CardList.Add(new Card(126, "Water", "Yellow", "7", 7));
        CardList.Add(new Card(127, "Water", "Yellow", "8", 8));
        CardList.Add(new Card(128, "Water", "Yellow", "9", 9));
        CardList.Add(new Card(129, "Water", "Yellow", "10", 10));
        CardList.Add(new Card(130, "Water", "Yellow", "F", 0));
        CardList.Add(new Card(131, "Water", "Yellow", "W", 0));
        CardList.Add(new Card(132, "Water", "Yellow", "E", 0));
        CardList.Add(new Card(133, "Water", "Yellow", "T", 0));
        CardList.Add(new Card(134, "Water", "Yellow", "B", 0));
        //
        CardList.Add(new Card(135, "Water", "Black", "1", 1));
        CardList.Add(new Card(136, "Water", "Black", "2", 2));
        CardList.Add(new Card(137, "Water", "Black", "3", 3));
        CardList.Add(new Card(138, "Water", "Black", "4", 4));
        CardList.Add(new Card(139, "Water", "Black", "5", 5));
        CardList.Add(new Card(140, "Water", "Black", "6", 6));
        CardList.Add(new Card(141, "Water", "Black", "7", 7));
        CardList.Add(new Card(142, "Water", "Black", "8", 8));
        CardList.Add(new Card(143, "Water", "Black", "9", 9));
        CardList.Add(new Card(144, "Water", "Black", "10", 10));
        CardList.Add(new Card(145, "Water", "Black", "F", 0));
        CardList.Add(new Card(146, "Water", "Black", "W", 0));
        CardList.Add(new Card(147, "Water", "Black", "E", 0));
        CardList.Add(new Card(148, "Water", "Black", "T", 0));
        CardList.Add(new Card(149, "Water", "Black", "B", 0));
        CardList.Add(new Card(150, "Earth", "Red", "1", 1));
        CardList.Add(new Card(151, "Earth", "Red", "2", 2));
        CardList.Add(new Card(152, "Earth", "Red", "3", 3));
        CardList.Add(new Card(153, "Earth", "Red", "4", 4));
        CardList.Add(new Card(154, "Earth", "Red", "5", 5));
        CardList.Add(new Card(155, "Earth", "Red", "6", 6));
        CardList.Add(new Card(156, "Earth", "Red", "7", 7));
        CardList.Add(new Card(157, "Earth", "Red", "8", 8));
        CardList.Add(new Card(158, "Earth", "Red", "9", 9));
        CardList.Add(new Card(159, "Earth", "Red", "10", 10));
        CardList.Add(new Card(160, "Earth", "Red", "F", 0));
        CardList.Add(new Card(161, "Earth", "Red", "W", 0));
        CardList.Add(new Card(162, "Earth", "Red", "E", 0));
        CardList.Add(new Card(163, "Earth", "Red", "T", 0));
        CardList.Add(new Card(164, "Earth", "Red", "B", 0));
        CardList.Add(new Card(165, "Earth", "Blue", "1", 1));
        CardList.Add(new Card(166, "Earth", "Blue", "2", 2));
        CardList.Add(new Card(167, "Earth", "Blue", "3", 3));
        CardList.Add(new Card(168, "Earth", "Blue", "4", 4));
        CardList.Add(new Card(169, "Earth", "Blue", "5", 5));
        CardList.Add(new Card(170, "Earth", "Blue", "6", 6));
        CardList.Add(new Card(171, "Earth", "Blue", "7", 7));
        CardList.Add(new Card(172, "Earth", "Blue", "8", 8));
        CardList.Add(new Card(173, "Earth", "Blue", "9", 9));
        CardList.Add(new Card(174, "Earth", "Blue", "10", 10));
        CardList.Add(new Card(175, "Earth", "Blue", "F", 0));
        CardList.Add(new Card(176, "Earth", "Blue", "W", 0));
        CardList.Add(new Card(177, "Earth", "Blue", "E", 0));
        CardList.Add(new Card(178, "Earth", "Blue", "T", 0));
        CardList.Add(new Card(179, "Earth", "Blue", "B", 0));
        CardList.Add(new Card(180, "Earth", "Brown", "1", 1));
        CardList.Add(new Card(181, "Earth", "Brown", "2", 2));
        CardList.Add(new Card(182, "Earth", "Brown", "3", 3));
        CardList.Add(new Card(183, "Earth", "Brown", "4", 4));
        CardList.Add(new Card(184, "Earth", "Brown", "5", 5));
        CardList.Add(new Card(185, "Earth", "Brown", "6", 6));
        CardList.Add(new Card(186, "Earth", "Brown", "7", 7));
        CardList.Add(new Card(187, "Earth", "Brown", "8", 8));
        CardList.Add(new Card(188, "Earth", "Brown", "9", 9));
        CardList.Add(new Card(189, "Earth", "Brown", "10", 10));
        CardList.Add(new Card(190, "Earth", "Brown", "F", 0));
        CardList.Add(new Card(191, "Earth", "Brown", "W", 0));
        CardList.Add(new Card(192, "Earth", "Brown", "E", 0));
        CardList.Add(new Card(193, "Earth", "Brown", "T", 0));
        CardList.Add(new Card(194, "Earth", "Brown", "B", 0));
        CardList.Add(new Card(195, "Earth", "Yellow", "1", 1));
        CardList.Add(new Card(196, "Earth", "Yellow", "2", 2));
        CardList.Add(new Card(197, "Earth", "Yellow", "3", 3));
        CardList.Add(new Card(198, "Earth", "Yellow", "4", 4));
        CardList.Add(new Card(199, "Earth", "Yellow", "5", 5));
        CardList.Add(new Card(200, "Earth", "Yellow", "6", 6));
        CardList.Add(new Card(201, "Earth", "Yellow", "7", 7));
        CardList.Add(new Card(202, "Earth", "Yellow", "8", 8));
        CardList.Add(new Card(203, "Earth", "Yellow", "9", 9));
        CardList.Add(new Card(204, "Earth", "Yellow", "10", 10));
        CardList.Add(new Card(205, "Earth", "Yellow", "F", 0));
        CardList.Add(new Card(206, "Earth", "Yellow", "W", 0));
        CardList.Add(new Card(207, "Earth", "Yellow", "E", 0));
        CardList.Add(new Card(208, "Earth", "Yellow", "T", 0));
        CardList.Add(new Card(209, "Earth", "Yellow", "B", 0));
        CardList.Add(new Card(210, "Earth", "Black", "1", 1));
        CardList.Add(new Card(211, "Earth", "Black", "2", 2));
        CardList.Add(new Card(212, "Earth", "Black", "3", 3));
        CardList.Add(new Card(213, "Earth", "Black", "4", 4));
        CardList.Add(new Card(214, "Earth", "Black", "5", 5));
        CardList.Add(new Card(215, "Earth", "Black", "6", 6));
        CardList.Add(new Card(216, "Earth", "Black", "7", 7));
        CardList.Add(new Card(217, "Earth", "Black", "8", 8));
        CardList.Add(new Card(218, "Earth", "Black", "9", 9));
        CardList.Add(new Card(219, "Earth", "Black", "10", 10));
        CardList.Add(new Card(220, "Earth", "Black", "F", 0));
        CardList.Add(new Card(221, "Earth", "Black", "W", 0));
        CardList.Add(new Card(222, "Earth", "Black", "E", 0));
        CardList.Add(new Card(223, "Earth", "Black", "T", 0));
        CardList.Add(new Card(224, "Earth", "Black", "B", 0));
        CardList.Add(new Card(225, "Thunder", "Red", "1", 1));
        CardList.Add(new Card(226, "Thunder", "Red", "2", 2));
        CardList.Add(new Card(227, "Thunder", "Red", "3", 3));
        CardList.Add(new Card(228, "Thunder", "Red", "4", 4));
        CardList.Add(new Card(229, "Thunder", "Red", "5", 5));
        CardList.Add(new Card(230, "Thunder", "Red", "6", 6));
        CardList.Add(new Card(231, "Thunder", "Red", "7", 7));
        CardList.Add(new Card(232, "Thunder", "Red", "8", 8));
        CardList.Add(new Card(233, "Thunder", "Red", "9", 9));
        CardList.Add(new Card(234, "Thunder", "Red", "10", 10));
        CardList.Add(new Card(235, "Thunder", "Red", "F", 0));
        CardList.Add(new Card(236, "Thunder", "Red", "W", 0));
        CardList.Add(new Card(237, "Thunder", "Red", "E", 0));
        CardList.Add(new Card(238, "Thunder", "Red", "T", 0));
        CardList.Add(new Card(239, "Thunder", "Red", "B", 0));
        CardList.Add(new Card(240, "Thunder", "Blue", "1", 1));
        CardList.Add(new Card(241, "Thunder", "Blue", "2", 2));
        CardList.Add(new Card(242, "Thunder", "Blue", "3", 3));
        CardList.Add(new Card(243, "Thunder", "Blue", "4", 4));
        CardList.Add(new Card(244, "Thunder", "Blue", "5", 5));
        CardList.Add(new Card(245, "Thunder", "Blue", "6", 6));
        CardList.Add(new Card(246, "Thunder", "Blue", "7", 7));
        CardList.Add(new Card(247, "Thunder", "Blue", "8", 8));
        CardList.Add(new Card(248, "Thunder", "Blue", "9", 9));
        CardList.Add(new Card(249, "Thunder", "Blue", "10", 10));
        CardList.Add(new Card(250, "Thunder", "Blue", "F", 0));
        CardList.Add(new Card(251, "Thunder", "Blue", "W", 0));
        CardList.Add(new Card(252, "Thunder", "Blue", "E", 0));
        CardList.Add(new Card(253, "Thunder", "Blue", "T", 0));
        CardList.Add(new Card(254, "Thunder", "Blue", "B", 0));
        CardList.Add(new Card(255, "Thunder", "Brown", "1", 1));
        CardList.Add(new Card(256, "Thunder", "Brown", "2", 2));
        CardList.Add(new Card(257, "Thunder", "Brown", "3", 3));
        CardList.Add(new Card(258, "Thunder", "Brown", "4", 4));
        CardList.Add(new Card(259, "Thunder", "Brown", "5", 5));
        CardList.Add(new Card(260, "Thunder", "Brown", "6", 6));
        CardList.Add(new Card(261, "Thunder", "Brown", "7", 7));
        CardList.Add(new Card(262, "Thunder", "Brown", "8", 8));
        CardList.Add(new Card(263, "Thunder", "Brown", "9", 9));
        CardList.Add(new Card(264, "Thunder", "Brown", "10", 10));
        CardList.Add(new Card(265, "Thunder", "Brown", "F", 0));
        CardList.Add(new Card(266, "Thunder", "Brown", "W", 0));
        CardList.Add(new Card(267, "Thunder", "Brown", "E", 0));
        CardList.Add(new Card(268, "Thunder", "Brown", "T", 0));
        CardList.Add(new Card(269, "Thunder", "Brown", "B", 0));
        CardList.Add(new Card(270, "Thunder", "Yellow", "1", 1));
        CardList.Add(new Card(271, "Thunder", "Yellow", "2", 2));
        CardList.Add(new Card(272, "Thunder", "Yellow", "3", 3));
        CardList.Add(new Card(273, "Thunder", "Yellow", "4", 4));
        CardList.Add(new Card(274, "Thunder", "Yellow", "5", 5));
        CardList.Add(new Card(275, "Thunder", "Yellow", "6", 6));
        CardList.Add(new Card(276, "Thunder", "Yellow", "7", 7));
        CardList.Add(new Card(277, "Thunder", "Yellow", "8", 8));
        CardList.Add(new Card(278, "Thunder", "Yellow", "9", 9));
        CardList.Add(new Card(279, "Thunder", "Yellow", "10", 10));
        CardList.Add(new Card(280, "Thunder", "Yellow", "F", 0));
        CardList.Add(new Card(281, "Thunder", "Yellow", "W", 0));
        CardList.Add(new Card(282, "Thunder", "Yellow", "E", 0));
        CardList.Add(new Card(283, "Thunder", "Yellow", "T", 0));
        CardList.Add(new Card(284, "Thunder", "Yellow", "B", 0));
        CardList.Add(new Card(285, "Thunder", "Black", "1", 1));
        CardList.Add(new Card(286, "Thunder", "Black", "2", 2));
        CardList.Add(new Card(287, "Thunder", "Black", "3", 3));
        CardList.Add(new Card(288, "Thunder", "Black", "4", 4));
        CardList.Add(new Card(289, "Thunder", "Black", "5", 5));
        CardList.Add(new Card(290, "Thunder", "Black", "6", 6));
        CardList.Add(new Card(291, "Thunder", "Black", "7", 7));
        CardList.Add(new Card(292, "Thunder", "Black", "8", 8));
        CardList.Add(new Card(293, "Thunder", "Black", "9", 9));
        CardList.Add(new Card(294, "Thunder", "Black", "10", 10));
        CardList.Add(new Card(295, "Thunder", "Black", "F", 0));
        CardList.Add(new Card(296, "Thunder", "Black", "W", 0));
        CardList.Add(new Card(297, "Thunder", "Black", "E", 0));
        CardList.Add(new Card(298, "Thunder", "Black", "T", 0));
        CardList.Add(new Card(299, "Thunder", "Black", "B", 0));
        CardList.Add(new Card(300, "Dark", "Red", "1", 1));
        CardList.Add(new Card(301, "Dark", "Red", "2", 2));
        CardList.Add(new Card(302, "Dark", "Red", "3", 3));
        CardList.Add(new Card(303, "Dark", "Red", "4", 4));
        CardList.Add(new Card(304, "Dark", "Red", "5", 5));
        CardList.Add(new Card(305, "Dark", "Red", "6", 6));
        CardList.Add(new Card(306, "Dark", "Red", "7", 7));
        CardList.Add(new Card(307, "Dark", "Red", "8", 8));
        CardList.Add(new Card(308, "Dark", "Red", "9", 9));
        CardList.Add(new Card(309, "Dark", "Red", "10", 10));
        CardList.Add(new Card(310, "Dark", "Red", "F", 0));
        CardList.Add(new Card(311, "Dark", "Red", "W", 0));
        CardList.Add(new Card(312, "Dark", "Red", "E", 0));
        CardList.Add(new Card(313, "Dark", "Red", "T", 0));
        CardList.Add(new Card(314, "Dark", "Red", "B", 0));
        CardList.Add(new Card(315, "Dark", "Blue", "1", 1));
        CardList.Add(new Card(316, "Dark", "Blue", "2", 2));
        CardList.Add(new Card(317, "Dark", "Blue", "3", 3));
        CardList.Add(new Card(318, "Dark", "Blue", "4", 4));
        CardList.Add(new Card(319, "Dark", "Blue", "5", 5));
        CardList.Add(new Card(320, "Dark", "Blue", "6", 6));
        CardList.Add(new Card(321, "Dark", "Blue", "7", 7));
        CardList.Add(new Card(322, "Dark", "Blue", "8", 8));
        CardList.Add(new Card(323, "Dark", "Blue", "9", 9));
        CardList.Add(new Card(324, "Dark", "Blue", "10", 10));
        CardList.Add(new Card(325, "Dark", "Blue", "F", 0));
        CardList.Add(new Card(326, "Dark", "Blue", "W", 0));
        CardList.Add(new Card(327, "Dark", "Blue", "E", 0));
        CardList.Add(new Card(328, "Dark", "Blue", "T", 0));
        CardList.Add(new Card(329, "Dark", "Blue", "B", 0));
        CardList.Add(new Card(330, "Dark", "Brown", "1", 1));
        CardList.Add(new Card(331, "Dark", "Brown", "2", 2));
        CardList.Add(new Card(332, "Dark", "Brown", "3", 3));
        CardList.Add(new Card(333, "Dark", "Brown", "4", 4));
        CardList.Add(new Card(334, "Dark", "Brown", "5", 5));
        CardList.Add(new Card(335, "Dark", "Brown", "6", 6));
        CardList.Add(new Card(336, "Dark", "Brown", "7", 7));
        CardList.Add(new Card(337, "Dark", "Brown", "8", 8));
        CardList.Add(new Card(338, "Dark", "Brown", "9", 9));
        CardList.Add(new Card(339, "Dark", "Brown", "10", 10));
        CardList.Add(new Card(340, "Dark", "Brown", "F", 0));
        CardList.Add(new Card(341, "Dark", "Brown", "W", 0));
        CardList.Add(new Card(342, "Dark", "Brown", "E", 0));
        CardList.Add(new Card(343, "Dark", "Brown", "T", 0));
        CardList.Add(new Card(344, "Dark", "Brown", "B", 0));
        CardList.Add(new Card(345, "Dark", "Yellow", "1", 1));
        CardList.Add(new Card(346, "Dark", "Yellow", "2", 2));
        CardList.Add(new Card(347, "Dark", "Yellow", "3", 3));
        CardList.Add(new Card(348, "Dark", "Yellow", "4", 4));
        CardList.Add(new Card(349, "Dark", "Yellow", "5", 5));
        CardList.Add(new Card(350, "Dark", "Yellow", "6", 6));
        CardList.Add(new Card(351, "Dark", "Yellow", "7", 7));
        CardList.Add(new Card(352, "Dark", "Yellow", "8", 8));
        CardList.Add(new Card(353, "Dark", "Yellow", "9", 9));
        CardList.Add(new Card(354, "Dark", "Yellow", "10", 10));
        CardList.Add(new Card(355, "Dark", "Yellow", "F", 0));
        CardList.Add(new Card(356, "Dark", "Yellow", "W", 0));
        CardList.Add(new Card(357, "Dark", "Yellow", "E", 0));
        CardList.Add(new Card(358, "Dark", "Yellow", "T", 0));
        CardList.Add(new Card(359, "Dark", "Yellow", "B", 0));
        CardList.Add(new Card(360, "Dark", "Black", "1", 1));
        CardList.Add(new Card(361, "Dark", "Black", "2", 2));
        CardList.Add(new Card(362, "Dark", "Black", "3", 3));
        CardList.Add(new Card(363, "Dark", "Black", "4", 4));
        CardList.Add(new Card(364, "Dark", "Black", "5", 5));
        CardList.Add(new Card(365, "Dark", "Black", "6", 6));
        CardList.Add(new Card(366, "Dark", "Black", "7", 7));
        CardList.Add(new Card(367, "Dark", "Black", "8", 8));
        CardList.Add(new Card(368, "Dark", "Black", "9", 9));
        CardList.Add(new Card(369, "Dark", "Black", "10", 10));
        CardList.Add(new Card(370, "Dark", "Black", "F", 0));
        CardList.Add(new Card(371, "Dark", "Black", "W", 0));
        CardList.Add(new Card(372, "Dark", "Black", "E", 0));
        CardList.Add(new Card(373, "Dark", "Black", "T", 0));
        CardList.Add(new Card(374, "Dark", "Black", "B", 0));
    }
}
