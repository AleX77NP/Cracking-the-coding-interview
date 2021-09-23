package com.company;

import java.util.Arrays;
import java.util.HashMap;

public class Main {

    // remove duplicates from string
    public static String removeDuplicates(String snt) {
        var sentence = snt.toCharArray();
        if(sentence.length < 2) {
            return sentence.toString();
        }
        var set = new StringBuilder();
        var hits = new HashMap<Character, Boolean>();

        for(int i=0; i< sentence.length; i++) {
            if(hits.get(sentence[i]) != null && hits.get(sentence[i]) == true ) {
                continue;
            }
            set.append(sentence[i]);
            hits.put(sentence[i], true);
        }

        return set.toString();
    }

    // check if strings are anagrams
    public static boolean areAnagrams(String str1, String str2) {
        if (str1.length() != str2.length()) {
            return false;
        }
        var ch1 = str1.toCharArray();
        Arrays.sort(ch1);
        var ch2 = str2.toCharArray();
        Arrays.sort(ch2);

        System.out.println(String.valueOf(ch1));
        System.out.println(String.valueOf(ch2));

        return String.valueOf(ch1).equals(String.valueOf(ch2));
    }

    // replace all spaces in string with %20
    public static String replaceSpaces(String sentence) {
        var temp = sentence.toCharArray();
        StringBuilder s = new StringBuilder();
        for (int i=0; i<sentence.length(); i++) {
            if(temp[i] == ' ') {
                s.append("%20");
            } else {
                s.append(temp[i]);
            }
        }
        return String.valueOf(s);
    }

    // if matrix elem is 0, set entire row and column do 0, deep copy use!
    public static void setZeroMatrix(int[][] matrix) {
        int[][] cp =Arrays.stream(matrix)
                .map(a ->  Arrays.copyOf(a, a.length))
                .toArray(int[][]::new);

        for (int i=0; i<matrix.length; i++) {
            for (int j=0; j<matrix[i].length; j++) {
                if(matrix[i][j] == 0) {
                    System.out.println("zero at " + String.valueOf(i) + " " + String.valueOf(j));
                    int temp = 0;
                    while(temp < matrix.length) {
                        cp[temp][j] = 0;
                        temp ++;
                    }
                    cp[i] = new int[matrix[i].length];
                }
            }
        }
        for (int i=0; i<cp.length; i++) {
            for (int j=0; j<cp[i].length; j++) {
                System.out.print(cp[i][j]);
                System.out.print(' ');
            }
            System.out.println("");
        }
    }

    public static void main(String[] args) {
        System.out.println(removeDuplicates("abababa"));
        System.out.println(areAnagrams("radnaskele", "aleksandar"));
        System.out.println(replaceSpaces("ja sam aco"));

        int mat[][] = {
                {1,7,8},
                {2,4,11},
                {3,0,4},
                {6,7,2}
        };
        setZeroMatrix(mat);
    }
}
