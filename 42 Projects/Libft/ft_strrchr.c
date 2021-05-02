/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strrchr.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 16:08:23 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 16:09:24 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

char	*ft_strrchr(const char *str, int c)
{
	const char *temp;

	temp = str;
	while (*str)
		str++;
	if (c == 0)
		return ((char*)str);
	while (str >= temp)
	{
		if (*str == (char)c)
			return ((char*)str);
		str--;
	}
	return (0);
}
